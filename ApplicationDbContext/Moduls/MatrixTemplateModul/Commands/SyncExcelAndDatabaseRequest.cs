using Application.Contracts.Repositories;
using Application.DTOS;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.MatrixTemplateModul.Commands
{
    public class SyncExcelAndDatabaseRequest : IRequest
    {
        public IEnumerable<UpdatedExcelRowDTO> UpdatedRows { get; set; }
    }
    public class SyncExcelAndDatabaseHandler : IRequestHandler<SyncExcelAndDatabaseRequest>
    {
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;

        public SyncExcelAndDatabaseHandler(IMatrixCombinationRepository matrixCombinationRepository)
        {
            _matrixCombinationRepository = matrixCombinationRepository;
        }

        public async Task<Unit> Handle(SyncExcelAndDatabaseRequest request, CancellationToken cancellationToken)
        {
            foreach (var updatedRow in request.UpdatedRows)
            {
                var dbRecord = await _matrixCombinationRepository.GetCombinationByLenderAndProductAsync(updatedRow.LenderName, updatedRow.ProductName, updatedRow.Tenor);

                if (dbRecord != null)
                {
                    dbRecord.Lender.Name = updatedRow.LenderName; 
                    dbRecord.Product.Name = updatedRow.ProductName; 
                    dbRecord.Tenor = updatedRow.Tenor;

                    await _matrixCombinationRepository.UpdateCombinationAsync(dbRecord);
                }
            }

            return Unit.Value;
        }
    }
}


