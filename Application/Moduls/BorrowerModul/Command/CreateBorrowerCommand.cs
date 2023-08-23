using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
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

namespace Application.Moduls.BorrowerModul.Command
{
    public sealed record CreateBorrowerCommand : IRequest<bool>
    {
        public string CompanyName { get; set; }
        public int CompanyTypeId { get; set; }
        //public Guid UserId { get; set; }
        public string VatNumber { get; set; }
        public string FiscalCode { get; set; }
        public string CultureId { get; set; }
    }
    public sealed class CreateBorrowerCommandHandler : IRequestHandler<CreateBorrowerCommand,bool>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateBorrowerCommand> _validationLocalizationService;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;


        public CreateBorrowerCommandHandler(IMapper mapper, IStringLocalizer<CreateBorrowerCommand> validationLocalizationService,
            IBorrowerRepository borrowerRepository, ICompanyTypeRepository companyTypeRepository, IHttpContextAccessor httpContextAccessor,
           UserManager<User> userManager)
        {
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationService;
            _borrowerRepository = borrowerRepository;
            _companyTypeRepository = companyTypeRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        public async Task<bool> Handle(CreateBorrowerCommand request, CancellationToken cancellationToken)
        {

            var uName = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(uName);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }
            Guid userId = new Guid(user.Id);

            var companyTypes = await _companyTypeRepository.GetAllCompanyTypesAsync(trackChanges: false);
           // var userBorrowers = await _borrowerRepository.GetBorrowersByUserIdAsync(user.Id);

            var validator = new CreateBorrowerValidation(_validationLocalizationService, request.CultureId, companyTypes);
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new FluentValidationException(errorMessages);
            }
            //request.UserId = userId;
            var borrowerForCreate = _mapper.Map<Borrower>(request);
            borrowerForCreate.UserId = userId.ToString();
            try
            {
                borrowerForCreate = _borrowerRepository.CreateBorrower(borrowerForCreate);
            }
            catch (Exception ex)
            {
                var duplicateFiscalCode = 12345678911;
                throw new DuplicateFiscalCodeException(request.CultureId);


            }
            return true;
        }
    }

}