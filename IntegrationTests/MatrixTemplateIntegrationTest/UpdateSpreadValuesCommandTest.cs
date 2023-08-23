using Xunit;
using Microsoft.EntityFrameworkCore;
using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Moduls.MatrixTemplateModul.Commands;
using Infrastructure.Repositories;
using Infrastructure;

namespace IntegrationTests.MatrixTemplateIntegrationTest
{
    public class UpdateSpreadValuesHandlerTest : IntegrationTest
    {
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IProductRepository _productRepository;

        public UpdateSpreadValuesHandlerTest()
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
                    LenderName = "PMI BTECH",
                    ProductName = "Installments with pre-amortization at a fixed rate",
                    Tenor=13,
                    Spread=0.5,
                   
                }
            };
             var command = new UpdateSpreadValuesCommand
            {
                SpreadUpdates = spreadUpdates
            };

            await handler.Handle(command, CancellationToken.None);
        }
    }
}
