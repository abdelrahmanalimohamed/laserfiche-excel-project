using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveProcessingFileController : ControllerBase
    {
        private readonly ISaveProcessingFile saveProcessingFile;

        public SaveProcessingFileController(ISaveProcessingFile _saveProcessingFile)
        {
            this.saveProcessingFile = _saveProcessingFile;
        }

        //[HttpPost]
        //[Route("saveprocessingfile")]
        //public async Task<IActionResult> SaveProcessingFile()
        //{
        //    return null;
        //}
    }
}
