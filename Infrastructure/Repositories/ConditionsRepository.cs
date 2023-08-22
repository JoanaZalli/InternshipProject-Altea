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
    public class ConditionsRepository : RepositoryBase<Condition>, IConditionsRepository
    {
        public ConditionsRepository(ApplicationDbContext context) : base(context) { }
        public async Task<IEnumerable<Condition>> GetAllConditionsAsync()
        {
            var conditions = await _context.Conditions.ToListAsync();
            return conditions;
        }
    }
}
