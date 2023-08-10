using Application.Contracts;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Model;
using Microsoft.EntityFrameworkCore;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyProfileController : ControllerBase
    {
        private readonly IFinhubService _finhubService;
        private readonly ApplicationDbContext _context;
        public CompanyProfileController(IFinhubService finhubService, ApplicationDbContext context)
        {
            _finhubService = finhubService;
            _context = context;

        }
        [HttpGet("update-all")]
        public async Task<IActionResult> UpdateAllCompanyProfiles()
        {
            string[] symbols = new string[] { "AAPL", "EXCOF", "UPOW" };

            foreach (string symbol in symbols)
            {
                CompanyProfile companyProfile = await _finhubService.GetCompanyProfileAsync(symbol);

                if (companyProfile != null)
                {
                    bool exists = await _context.CompanyProfiles.AnyAsync(cp => cp.Symbol == symbol);

                    if (!exists)
                    {
                        _context.CompanyProfiles.Add(companyProfile);
                    }
                    else
                    {
                        CompanyProfile existingProfile = await _context.CompanyProfiles.FirstOrDefaultAsync(cp => cp.Symbol == symbol);
                        if (existingProfile != null)
                        {
                            existingProfile.Name = companyProfile.Name;
                            existingProfile.Description = companyProfile.Description;
                            existingProfile.Phone = companyProfile.Phone;
                            existingProfile.State = companyProfile.State;
                            existingProfile.Url = companyProfile.Url;
                            existingProfile.Adress = companyProfile.Adress;
                            existingProfile.Sector = companyProfile.Sector;
                            existingProfile.SubSector = companyProfile.SubSector;
                            existingProfile.NationalIndustry = companyProfile.NationalIndustry;
                            existingProfile.Currency = companyProfile.Currency;
                        }
                    }
                }
            }

            await _context.SaveChangesAsync();
            return Ok("Company profiles updated.");
        }
    }
}
