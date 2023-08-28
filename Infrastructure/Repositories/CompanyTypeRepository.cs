using Application.Contracts.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyTypeRepository : RepositoryBase<CompanyType>,ICompanyTypeRepository
    {
        public CompanyTypeRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<CompanyType>> GetAllCompanyTypesAsync(bool trcakChanges) => await GetAll(trcakChanges).ToListAsync();

    }
}
