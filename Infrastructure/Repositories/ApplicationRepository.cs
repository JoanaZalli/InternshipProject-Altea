using Application.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ApplicationRepository :RepositoryBase<Applicationn>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context) { }
        public Applicationn CreateApplication(Applicationn application)
        {
           application.DateCreated = DateTime.Now;
            application.DateUpdated = DateTime.Now;
            application.IsApproved = false;
            application.ApplicationName = (application.DateCreated).ToString() + (application.RequestedAmount).ToString();
            application.ApplicationStatusId = 1;
            _context.Add(application);
            _context.SaveChanges();
            return application;
        }

    }
}
