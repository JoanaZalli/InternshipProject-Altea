using Application.Contracts;
using Application.Moduls.CompanyProfileModul;
using Application.Moduls.CompanyProfileModul.Command;
using Domain.Entities;
using Hangfire;
using Infrastructure;
using Infrastructure.Services;
using MediatR;
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
        
        private readonly IMediator _mediator;
        private readonly CompanyProfileSchedulingService _profileSchedulingService;

        public CompanyProfileController( IMediator mediator,CompanyProfileSchedulingService companyProfileSchedulingService)
        {
          
            _mediator = mediator;
            _profileSchedulingService = companyProfileSchedulingService;

        }
        [HttpGet("getCompanyProfiles")]
        public async Task<IActionResult> GetAllCompanyProfiles()
        {
            await _mediator.Send(new UpdateCompanyProfilesCommand());

            return Ok("Company profiles updated.");
        }
        [HttpPut("loanOfficer/schedule-update")]
        public IActionResult ScheduleDailyUpdateAction()
        {
            _profileSchedulingService.ScheduleDailyUpdate();

            return Ok("Daily company profile updates scheduled.");
        }
    }
}