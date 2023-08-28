using Application.Contracts;
using Application.Exceptions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class FinhubService : IFinhubService
    {
        private readonly HttpClient _httpClient;

        public FinhubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("cjadtshr01qji1gtidbg", "cjed84hr01qgod9alaq0cjed84hr01qgod9alaqg");

        }
        public async Task<CompanyProfile> GetCompanyProfileAsync(string symbol)
        {
                var apiKey = "cjed84hr01qgod9alaq0cjed84hr01qgod9alaqg";
                string apiUrl = $"https://finnhub.io/api/v1/stock/profile2?symbol={symbol}&token={apiKey}";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<CompanyProfile>();
                    if (result != null)
                    {
                        CompanyProfile companyProfile = new CompanyProfile
                        {
                            ticker = symbol,
                            name = result.name,
                            exchange = result.exchange,
                            phone = result.phone,
                            ipo = result.ipo,
                            weburl = result.weburl,
                            marketCapitalization = result.marketCapitalization,
                            shareOutstanding = result.shareOutstanding,
                            logo = result.logo,
                            finnhubIndustry = result.finnhubIndustry,
                            currency = result.currency,
                            country = result.country,
                        };
                        return companyProfile;
                    }
            }
            else
            {
                throw new FinhubFaildException();
            }
                
                
                return null; 
           
        }

    }
}
