using Application.Moduls.MatrixTemplateModul;
using Application.Moduls.MatrixTemplateModul.Commands;
using Application.Moduls.MatrixTemplateModul.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("generate")]
        public async Task<IActionResult> GenerateExcelFile()
        {
            var command = new GenerateExcelFileCommand { MinTenor = 11, MaxTenor = 65 };
            var fileBytes = await _mediator.Send(command);
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Combinations.xlsx");
        }
        [HttpPost("upload/{fileIdentifier}")]
        public async Task<IActionResult> UploadExcelFile(string fileIdentifier, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file was uploaded.");
            }

            using (var stream = file.OpenReadStream())
            {
                var updatedRows = ExcelFileParser.Parse(stream);

                if (updatedRows == null || !updatedRows.Any())
                {
                    return BadRequest("No valid data found in the uploaded Excel file.");
                }

                try
                {
                    var command = new UpdateMatrixCombinationsCommand(updatedRows);
                    await _mediator.Send(command);

                    return Ok("Matrix combinations updated successfully.");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating matrix combinations.");
                }
            }
        }
    }
}
