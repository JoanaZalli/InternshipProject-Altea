using Application.Contracts;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
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
                    bool exists = await _context.CompanyProfiles.AnyAsync(cp => cp.ticker == symbol);

                    if (!exists)
                    {
                        _context.CompanyProfiles.Add(companyProfile);
                        _context.SaveChanges();
                    }
                    else
                    {
                        CompanyProfile existingProfile = await _context.CompanyProfiles.FirstOrDefaultAsync(cp => cp.ticker == symbol);
                        if (existingProfile != null)
                        {
                            existingProfile.name = companyProfile.name;
                            existingProfile.description = companyProfile.description;
                            existingProfile.phone = companyProfile.phone;
                            existingProfile.state = companyProfile.state;
                            existingProfile.weburl = companyProfile.weburl;
                            existingProfile.address = companyProfile.address;
                            existingProfile.naicsSector = companyProfile.naicsSector;
                            existingProfile.naicsSubsector = companyProfile.naicsSubsector;
                            existingProfile.naicsNationalIndustry = companyProfile.naicsNationalIndustry;
                            existingProfile.currency = companyProfile.currency;
                        }
                    }
                }
            }

            await _context.SaveChangesAsync();
            return Ok("Company profiles updated.");
        }
    }
}
