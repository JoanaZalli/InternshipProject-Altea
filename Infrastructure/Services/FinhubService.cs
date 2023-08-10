using Application.Contracts;
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
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Secret", "cjadtshr01qji1gtidbg");

        }
        public async Task<CompanyProfile> GetCompanyProfileAsync(string symbol)
        {
            string apiKey = "cjadtshr01qji1gtida0cjadtshr01qji1gtidag";
            string apiUrl = $"https://finnhub.io/api/v1/stock/profile2?symbol={symbol}&token={apiKey}";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                if (result != null)
                {
                    CompanyProfile companyProfile = new CompanyProfile
                    {
                        Symbol = symbol,
                        Name = result.GetValueOrDefault("name"),
                        Description = result.GetValueOrDefault("description"),
                        Phone = result.GetValueOrDefault("phone"),
                        State = result.GetValueOrDefault("state"),
                        Url = result.GetValueOrDefault("weburl"),
                        Adress = result.GetValueOrDefault("address"),
                        Sector = result.GetValueOrDefault("gsector"),
                        SubSector = result.GetValueOrDefault("naicsSubsector"),
                        NationalIndustry = result.GetValueOrDefault("naicsNationalIndustry"),
                        Currency = result.GetValueOrDefault("currency")
                    };

                    return companyProfile;
                }
            }
            return null;
        }
    }
}
