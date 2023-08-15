using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IMatrixCombinationRepository
    {
        Task AddCombinationAsync(MatrixTemplate combination);
        Task<MatrixTemplate> GetCombinationByLenderAndProductAsync(int lenderId, int productId, int tenor);
        Task<IEnumerable<MatrixTemplate>> GetCombinationsAsync();

        Task UpdateSpreadAsync(string lenderName, string productName, int tenor, double spread);
        Task UploadExcelAsync(Stream excelFileStream);


    }
}
