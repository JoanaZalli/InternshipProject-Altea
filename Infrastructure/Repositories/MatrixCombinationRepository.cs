using Application.Contracts.Repositories;
using Application.DTOS;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MatrixCombinationRepository : IMatrixCombinationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILenderRepository _lenderRepository;
        private readonly IProductRepository _productRepository;
        public MatrixCombinationRepository(ApplicationDbContext context,ILenderRepository lenderRepository, IProductRepository productRepository)  {
            _context = context;
            _lenderRepository = lenderRepository;   
            _productRepository = productRepository;
        
        }
        public async Task AddCombinationAsync(MatrixTemplate combination)
        {

            _context.MatrixTemplates.Add(combination);
            await _context.SaveChangesAsync();
        }
        public async Task<MatrixTemplate> GetCombinationByLenderAndProductAsync(int lenderId, int productId, int tenor)
        {
            var updatedRows = await _context.MatrixTemplates
                .Include(mt => mt.Lender)
                .Include(mt => mt.Product)
                .Where(mt => mt.Lender.Id == lenderId && mt.Product.Id == productId && mt.Tenor == tenor)
                .FirstOrDefaultAsync();
            return updatedRows;
        }

        public async Task<IEnumerable<MatrixTemplate>> GetCombinationsAsync()
        {
            var combinations = await _context.MatrixTemplates
                .Include(mt => mt.Lender)
                .Include(mt => mt.Product)
                .ToListAsync();
            return combinations;
        }

        public async Task UpdateSpreadAsync(string lenderName, string productName, int tenor, double spread)
        {
            var lender = await _lenderRepository.GetLenderByNameAsync(lenderName);
            var product = await _productRepository.GetProductByNameAsync(productName);

            if (lender != null && product != null)
            {
                var combination = await GetCombinationByLenderAndProductAsync(lender.Id, product.Id, tenor);

                if (combination != null)
                {
                    combination.Spread = spread;
                    await _context.SaveChangesAsync();
                }
            }
        }
        public async Task UploadExcelAsync(Stream excelFileStream)
        {
            using (var package = new ExcelPackage(excelFileStream))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    var lenderName = worksheet.Cells[row, 2].Value.ToString();
                    var productName = worksheet.Cells[row, 3].Value.ToString();
                    var tenor = Convert.ToInt32(worksheet.Cells[row, 4].Value);
                    var spread = Convert.ToDouble(worksheet.Cells[row, 5].Value);

                    await UpdateSpreadAsync(lenderName, productName, tenor, spread);
                }
            }
        }
    }
}