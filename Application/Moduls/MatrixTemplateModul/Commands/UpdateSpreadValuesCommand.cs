using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.MatrixTemplateModul.Commands
{
    public class UpdateSpreadValuesCommand : IRequest
    {
        public IEnumerable<UpdatedExcelRowDTO> SpreadUpdates { get; set; }
        public string cultureId { get; set; }
    }
    public class UpdateSpreadValuesHandler : IRequestHandler<UpdateSpreadValuesCommand>
    {
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IProductRepository _productRepository;
        public UpdateSpreadValuesHandler(IMatrixCombinationRepository matrixCombinationRepository, ILenderRepository lenderRepository, IProductRepository productRepository)
        {
            _matrixCombinationRepository = matrixCombinationRepository;
            _lenderRepository = lenderRepository;
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateSpreadValuesCommand request, CancellationToken cancellationToken)
        {
            if (request.SpreadUpdates == null)
            {
                // Handle the case when SpreadUpdates is null
                return Unit.Value;
            }
            foreach (var spreadUpdate in request.SpreadUpdates)
            {
                var lender = await _lenderRepository.GetLenderByNameAsync(spreadUpdate.LenderName);
                var product = await _productRepository.GetProductByNameAsync(spreadUpdate.ProductName);

                if (lender != null && product != null)
                {
                    var existingCombination = await _matrixCombinationRepository.GetCombinationByLenderAndProductAsync(
                        lender.Id, product.Id, spreadUpdate.Tenor);

                    if (existingCombination != null && existingCombination.Spread != spreadUpdate.Spread)
                    {
                        await _matrixCombinationRepository.UpdateSpreadAsync(
                            lender.Name, product.Name, spreadUpdate.Tenor, spreadUpdate.Spread);
                    }
                }
                if (lender == null || product == null || spreadUpdate.Tenor == 0 || spreadUpdate.Spread == 0)
                {
                    throw new MatrixTemplateException(request.cultureId);
                }

            }


            return Unit.Value;
        }
    }
}

