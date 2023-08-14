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
        Task UpdateCombinationsAsync(IEnumerable<UpdatedExcelRowDTO> updatedRows);
        Task<MatrixTemplate> GetCombinationByLenderAndProductAsync(string lenderName, string productName, int tenor);
        Task UpdateCombinationAsync(MatrixTemplate combination); 



    }
}
