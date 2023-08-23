using Application.Contracts.Repositories;
using Infrastructure.Repositories;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOS;
using Application.Moduls.MatrixTemplateModul.Commands;
using Application.Exceptions;

namespace IntegrationTests.MatrixTemplateIntegrationTest
{
    public class UpdateSpreadValuesFail : IntegrationTest
    {
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IProductRepository _productRepository;
        public UpdateSpreadValuesFail()
        {
            var dbContext = new ApplicationDbContext(GetDbContextOptions());
            _lenderRepository = new LenderRepository(dbContext);
            _productRepository = new ProductRepository(dbContext);
            _matrixCombinationRepository = new MatrixCombinationRepository(dbContext, _lenderRepository, _productRepository);

        }
        [Fact]
        public async Task UpdateSpreadValues()
        {
            var handler = new UpdateSpreadValuesHandler(_matrixCombinationRepository, _lenderRepository, _productRepository);

            var spreadUpdates = new List<UpdatedExcelRowDTO>
            {
                new UpdatedExcelRowDTO
                {
                    LenderName = "TestFail",
                    ProductName = "Installments with pre-amortization at a fixed rate",
                    Tenor=63,
                    Spread=0.5,

                }
            };
            var command = new UpdateSpreadValuesCommand
            {
                SpreadUpdates = spreadUpdates
            };

            await Assert.ThrowsAsync<MatrixTemplateException>(async () => await handler.Handle(command, CancellationToken.None));
        }
    }
}