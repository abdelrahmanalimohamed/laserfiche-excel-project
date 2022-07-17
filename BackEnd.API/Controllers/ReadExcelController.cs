using Application.Business_Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Threading.Tasks;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    public class ReadExcelController : ControllerBase
    {
        private readonly IReadExcelSheets ireadExcelSheets;

        public ReadExcelController(IReadExcelSheets readExcelSheets)
        {
            this.ireadExcelSheets = readExcelSheets;
        }

        [HttpPost , DisableRequestSizeLimit]
        [Route("TestRead")]
        public async Task<IActionResult> ReadExcelSheets()
        {
            var list = await ireadExcelSheets.ReadExcelSheet();
            return Ok(list);

           // return JsonResult(list);
        }
    }
}
