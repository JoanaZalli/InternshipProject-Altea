using Application.Contracts.Repositories;
using Application.Moduls.BorrowerModul.Command;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.ApplicationModul.Commands
{
        public sealed record CreateApplicationCommand : IRequest<bool>
        {
            public string ApplicationName { get; set; }

            public decimal RequestedAmount { get; set; }
            public decimal RequestedTenor { get; set; }
            public string FinancingPurposeDescription { get; set; }
        }
    public sealed class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateBorrowerCommand> _validationLocalizationService;
        private readonly IApplicationRepository _applicationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateApplicationCommandHandler(IMapper mapper, IStringLocalizer<CreateBorrowerCommand> validationLocalizationService,
            IApplicationRepository applicationRepository, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationService;
            _applicationRepository = applicationRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
        }

    }

}
