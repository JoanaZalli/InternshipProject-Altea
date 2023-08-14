using Application.Contracts.Repositories;
using Application.DTOS;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MatrixCombinationRepository : RepositoryBase<MatrixTemplate>, IMatrixCombinationRepository
    {
        public MatrixCombinationRepository(ApplicationDbContext context) : base(context) { }
        public async Task AddCombinationAsync(MatrixTemplate combination)
        {

            _context.MatrixTemplates.Add(combination);
            await _context.SaveChangesAsync();
        }
        public async Task<MatrixTemplate> GetCombinationByLenderAndProductAsync(string lenderName, string productName, int tenor)
        {
            var updatedRows= await _context.MatrixTemplates
                .Include(mt => mt.Lender)
                .Include(mt => mt.Product)
                .Where(mt => mt.Lender.Name == lenderName && mt.Product.Name == productName && mt.Tenor == tenor)
                .FirstOrDefaultAsync();
            return updatedRows;
        }
        public async Task UpdateCombinationsAsync(IEnumerable<UpdatedExcelRowDTO> updatedRows)
        {
            foreach (var updatedRow in updatedRows)
            {
                var existingCombination = await GetCombinationByLenderAndProductAsync(
                    updatedRow.LenderName, updatedRow.ProductName, updatedRow.Tenor);

                if (existingCombination != null)
                {
                    existingCombination.Spread = updatedRow.Spread;
                }
                else
                {
                    var newCombination = new MatrixTemplate
                    {
                        Lender = new Lender { Name = updatedRow.LenderName },
                        Product = new Product { Name = updatedRow.ProductName },
                        Tenor = updatedRow.Tenor,
                        Spread = updatedRow.Spread
                    };
                    _context.MatrixTemplates.Add(newCombination);
                }
            }

            await _context.SaveChangesAsync();
        }
        public async Task UpdateCombinationAsync(MatrixTemplate combination)
        {
            _context.MatrixTemplates.Update(combination);
            await _context.SaveChangesAsync();
        }

    }
}
