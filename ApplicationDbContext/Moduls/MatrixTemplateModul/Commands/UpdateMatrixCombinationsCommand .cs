using Application.Contracts.Repositories;
using Application.DTOS;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.MatrixTemplateModul.Commands
{
    public class UpdateMatrixCombinationsCommand : IRequest
    {
        public IEnumerable<UpdatedExcelRowDTO> UpdatedRows { get; set; }

        public UpdateMatrixCombinationsCommand(IEnumerable<UpdatedExcelRowDTO> updatedRows)
        {
            UpdatedRows = updatedRows;
        }
    }
    public class UpdateMatrixCombinationsCommandHandler : IRequestHandler<UpdateMatrixCombinationsCommand>
    {
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;

        public UpdateMatrixCombinationsCommandHandler(IMatrixCombinationRepository matrixCombinationRepository)
        {
            _matrixCombinationRepository = matrixCombinationRepository;
        }

        public async Task<Unit> Handle(UpdateMatrixCombinationsCommand request, CancellationToken cancellationToken)
        {
            if (request.UpdatedRows == null || !request.UpdatedRows.Any())
            {
                throw new ArgumentException("No valid data found in the uploaded Excel file.");
            }

            foreach (var updatedRow in request.UpdatedRows)
            {
                var existingCombination = await _matrixCombinationRepository.GetCombinationByLenderAndProductAsync(
                    updatedRow.LenderName, updatedRow.ProductName, updatedRow.Tenor);

                if (existingCombination != null)
                {
                    existingCombination.Spread = updatedRow.Spread;
                    await _matrixCombinationRepository.UpdateCombinationAsync(existingCombination);
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
                    await _matrixCombinationRepository.AddCombinationAsync(newCombination);
                }
            }

            return Unit.Value;
        }

    }
}


