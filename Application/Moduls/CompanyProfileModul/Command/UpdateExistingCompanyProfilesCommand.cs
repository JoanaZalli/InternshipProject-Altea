using Application.Contracts.Repositories;
using Application.Contracts;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.CompanyProfileModul.Command
{
    public class UpdateExistingCompanyProfilesCommand : IRequest
    {
    }
    public class UpdateExistingCompanyProfilesCommandHandler : IRequestHandler<UpdateExistingCompanyProfilesCommand>
    {
        private readonly IFinhubService _finhubService;
        private readonly ICompanyProfileRepository _companyProfileRepository;

        public UpdateExistingCompanyProfilesCommandHandler(IFinhubService finhubService, ICompanyProfileRepository companyProfileRepository)
        {
            _finhubService = finhubService;
            _companyProfileRepository = companyProfileRepository;
        }

        public async Task<Unit> Handle(UpdateExistingCompanyProfilesCommand request, CancellationToken cancellationToken)
        {
            string[] symbols = new string[] { "AAPL", "EXCOF", "UPOW", "IBM" };

            foreach (string symbol in symbols)
            {
                CompanyProfile companyProfile = await _finhubService.GetCompanyProfileAsync(symbol);

                if (companyProfile != null)
                {
                    CompanyProfile existingProfile = await _companyProfileRepository.GetByTickerAsync(symbol);

                    if (existingProfile == null)
                    {
                        await _companyProfileRepository.AddAsync(companyProfile);
                    }
                    else
                    {
                        existingProfile.name = companyProfile.name;
                        existingProfile.country = companyProfile.country;
                        existingProfile.phone = companyProfile.phone;
                        existingProfile.currency = companyProfile.currency;
                        existingProfile.weburl = companyProfile.weburl;
                        existingProfile.exchange = companyProfile.exchange;
                        existingProfile.ipo = companyProfile.ipo;
                        existingProfile.marketCapitalization = companyProfile.marketCapitalization;
                        existingProfile.finnhubIndustry = companyProfile.finnhubIndustry;
                        existingProfile.currency = companyProfile.currency;
                        existingProfile.exchange = companyProfile.currency;
                        existingProfile.ticker = companyProfile.ticker;
                    }
                }
            }

            await _companyProfileRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}