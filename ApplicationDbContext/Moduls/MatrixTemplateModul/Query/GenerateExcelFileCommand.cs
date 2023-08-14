using Application.Contracts;
using Application.Contracts.Repositories;
using MediatR;
using OfficeOpenXml;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Moduls.MatrixTemplateModul.Query
{
    public class GenerateExcelFileCommand : IRequest<byte[]>
    {
        public int MinTenor { get; set; }
        public int MaxTenor { get; set; }
    }

    public class GenerateExcelFileCommandHandler : IRequestHandler<GenerateExcelFileCommand, byte[]>
    {
        private readonly IMatrixCombinationsServices _matrixCombinations;
        private readonly IProductRepository _productRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IMatrixCombinationRepository _matrixCombinationRepository;

        public GenerateExcelFileCommandHandler(IMatrixCombinationsServices matrixCombinations, IMatrixCombinationRepository matrixCombinationRepository,
            ILenderRepository lenderRepository, IProductRepository productRepository)
        {
            _matrixCombinations = matrixCombinations;
            _matrixCombinationRepository = matrixCombinationRepository;
            _lenderRepository = lenderRepository;
            _productRepository = productRepository;
        }

        public async Task<byte[]> Handle(GenerateExcelFileCommand request, CancellationToken cancellationToken)
        {
            var lenders = await _lenderRepository.GetLenderAsync();
            var products = await _productRepository.GetProductAsync();

            var combinations = await _matrixCombinations.GenerateCombinations(lenders, products, request.MinTenor, request.MaxTenor);

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Combinations");

                worksheet.Cells[1, 1].Value = "ExcelId";
                worksheet.Cells[1, 2].Value = "Lender";
                worksheet.Cells[1, 3].Value = "Product";
                worksheet.Cells[1, 4].Value = "Tenor";
                worksheet.Cells[1, 5].Value = "Spread";

                int excelRow = 2;
                foreach (var combination in combinations)
                {
                    worksheet.Cells[excelRow, 1].Value = excelRow - 1;
                    worksheet.Cells[excelRow, 2].Value = combination.Lender.Name;
                    worksheet.Cells[excelRow, 3].Value = combination.Product.Name;
                    worksheet.Cells[excelRow, 4].Value = combination.Tenor;
                    excelRow++;
                }
                foreach (var combination in combinations)
                {
                    await _matrixCombinationRepository.AddCombinationAsync(combination);
                }
                using (var memoryStream = new MemoryStream())
                {
                    package.SaveAs(memoryStream);
                    return memoryStream.ToArray();
                }
            }
        }
    }
}
