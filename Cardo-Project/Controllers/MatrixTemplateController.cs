using Application.DTOS;
using Application.Moduls.MatrixTemplateModul;
using Application.Moduls.MatrixTemplateModul.Commands;
using Application.Moduls.MatrixTemplateModul.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatrixTemplateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MatrixTemplateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("store")]
        public async Task<IActionResult> StoreCombinations()
        {
            var command = new StoreCombinationsCommand(); 
            var result=await _mediator.Send(command);

            return Ok(result);
        }
        [HttpGet("download")]
        public async Task<IActionResult> DownloadCombinations()
        {
            var command = new GenerateExcelFileCommand { MinTenor = 11, MaxTenor = 65 };
            var fileBytes = await _mediator.Send(command);

            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Combinations.xlsx");
        }

        [HttpPatch("upload")]
        public async Task<IActionResult> UploadExcel(IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                return BadRequest("Invalid file.");
            }

            using (var stream = file.OpenReadStream())
            {
                var spreadUpdates = new List<UpdatedExcelRowDTO>();

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var updatedRow = new UpdatedExcelRowDTO
                        {
                            LenderName = worksheet.Cells[row, 2].Value.ToString(),
                            ProductName = worksheet.Cells[row, 3].Value.ToString(),
                            Tenor = Convert.ToInt32(worksheet.Cells[row, 4].Value),
                            Spread = Convert.ToDouble(worksheet.Cells[row, 5].Value)
                        };

                        spreadUpdates.Add(updatedRow);
                    }
                }

                var command = new UpdateSpreadValuesCommand
                {
                    SpreadUpdates = spreadUpdates
                };

                await _mediator.Send(command);

                return Ok("Excel file uploaded and spreads updated.");
            }
        }

    }
}

