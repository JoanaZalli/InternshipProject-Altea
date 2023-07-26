using Application.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
     public abstract class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {

        protected ApplicationDbContext _context;
        public RepositoryBase(ApplicationDbContext context)=>_context = context;

        public IQueryable<T> GetAll(bool trackChanges) =>
         !trackChanges ?
         _context.Set<T>()
         .AsNoTracking() :
         _context.Set<T>();

      
        public void Create(T entity) =>_context.Set<T>().Add(entity);
        public void Update(T entity)=>_context.Set<T>().Update(entity);
        public void Delete (T entity)=>_context.Set<T>().Remove(entity);
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
