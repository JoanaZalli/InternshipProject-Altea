using Application.Moduls.CompanyProfileModul.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CompanyProfileSchedulingService
    {
        private readonly IMediator _mediator;

        public CompanyProfileSchedulingService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void ScheduleDailyUpdate()
        {
            _mediator.Send(new UpdateExistingCompanyProfilesCommand()).Wait();
        }
    }
}
