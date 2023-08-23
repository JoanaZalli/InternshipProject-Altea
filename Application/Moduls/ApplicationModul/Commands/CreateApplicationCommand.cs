using Application.Contracts.Repositories;
using Application.Exceptions;
using Application.Moduls.BorrowerModul.Command;
using Application.Validations;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.ApplicationModul.Commands
{
        public sealed record CreateApplicationCommand : IRequest<bool>
        {        
            public int BorrowerId { get; set; }

            public decimal RequestedAmount { get; set; }
            public decimal RequestedTenor { get; set; }
            public string FinancingPurposeDescription { get; set; }
            public string CultureId { get; set; }

    }
    public sealed class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateApplicationCommand> _validationLocalizationService;
        private readonly IApplicationRepository _applicationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IProductRepository _productRepository;


        public CreateApplicationCommandHandler(IMapper mapper, IStringLocalizer<CreateApplicationCommand> validationLocalizationService,
            IApplicationRepository applicationRepository, IHttpContextAccessor httpContextAccessor,
            UserManager<User> userManager, IBorrowerRepository borrowerRepository
            ,IProductRepository productRepository)

        {
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationService;
            _applicationRepository = applicationRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _borrowerRepository = borrowerRepository;
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var uName = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(uName);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }

            var borrowers = await _borrowerRepository.GetBorrowersByUserIdAsync(user.Id);
            var borrower = borrowers.FirstOrDefault(b => b.Id == request.BorrowerId);
            if (borrower == null)
            {
                throw new BorrowerNotFoundException(request.CultureId);
            }
            var validator = new CreateApplicationValidation(_validationLocalizationService, request.CultureId);
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new FluentValidationException(errorMessages);
            }
            var application = _mapper.Map<Applicationn>(request);
            application.ProductId = 1;
            var product =await  _productRepository.GetProductAsync(application.ProductId);
            if(application.RequestedAmount>product.Max_Financed_Amount || application.RequestedAmount < product.Min_Financed_Amount)
            {
                throw new ApplicationNotCreatedException(request.CultureId);
            }
            application=_applicationRepository.CreateApplication(application);

            return true;
        }
        
    }

}
