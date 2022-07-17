using Application.Business_Logic;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelUploadController : ControllerBase
    {
        private readonly IUploadExcel iuploadExcel;

       // private readonly ISaveProcessingFile saveProcessingFile;


        public ExcelUploadController(IUploadExcel iupload , ISaveProcessingFile processingFile)
        {
            this.iuploadExcel = iupload;
          //  this.saveProcessingFile = processingFile;
        }

        [HttpPost, DisableRequestSizeLimit]
        [Route("Upload")]
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();

                var checkFileUploading =  await iuploadExcel.UploadFile(file);

               // var SaveProcessingFile = saveProcessingFile.SaveProcessingFileToDB(file.Name, null);

                if (checkFileUploading  == true)
                {
                    return StatusCode(200, "Uploaded Successfully");
                }
                else
                {
                    return BadRequest();
                }

                
               
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }


        }
        }
}
