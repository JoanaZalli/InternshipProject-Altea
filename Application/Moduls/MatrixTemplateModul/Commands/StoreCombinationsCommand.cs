using Application.Contracts;
using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.MatrixTemplateModul.Commands
{
    public class StoreCombinationsCommand : IRequest
    {
        public string CultureId { get; set; }
    }
    public class StoreCombinationsHandler : IRequestHandler<StoreCombinationsCommand>
    {
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;
        private readonly IMatrixCombinationsServices _matrixCombinations;
        private readonly ILenderRepository _lenderRepository;
        private readonly IProductRepository _productRepository;

        public StoreCombinationsHandler(
            IMatrixCombinationRepository matrixCombinationRepository,
            IMatrixCombinationsServices matrixCombinations,
            ILenderRepository lenderRepository,
            IProductRepository productRepository)
        {
            _matrixCombinationRepository = matrixCombinationRepository;
            _matrixCombinations = matrixCombinations;
            _lenderRepository = lenderRepository;
            _productRepository = productRepository;
        }
        public async Task<Unit> Handle(StoreCombinationsCommand request, CancellationToken cancellationToken)
        {
            var lenders = await _lenderRepository.GetLenderAsync();
            var products = await _productRepository.GetProductAsync();

            foreach (var lender in lenders)
            {
                foreach (var product in products)
                {
                    for (int tenor = 11; tenor <= 65; tenor++)
                    {
                        var existingCombination = await _matrixCombinationRepository.GetCombinationByLenderAndProductAsync(
                            lender.Id, product.Id, tenor);

                        if (existingCombination == null)
                        {
                           

                            await _matrixCombinationRepository.AddCombinationAsync(new MatrixTemplate
                            {
                                Lender = lender,
                                Product = product,
                                Tenor = tenor,

                            });
                        }
                        else if(existingCombination != null)
                        {
                            throw new CombinationExistsException(request.CultureId);
                        }
                    }
                }
            }

            return Unit.Value;
        }
    }
}
