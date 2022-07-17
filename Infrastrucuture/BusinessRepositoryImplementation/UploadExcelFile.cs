using Application.Business_Logic;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucuture.BusinessRepositoryImplementation
{
    public class UploadExcelFile : IUploadExcel
    {

        private readonly ISaveProcessingFile saveProcessingFile;
        public UploadExcelFile(ISaveProcessingFile processingFile)
        {
            saveProcessingFile = processingFile;
        }
        public async Task<bool> UploadFile(IFormFile formFile)
        {
            bool uploaded = false;

            var folderName = Path.Combine("Resources", "ProcessingFiles");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (formFile.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(formFile.ContentDisposition).FileName.Trim('"');
               
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);

                 await saveProcessingFile.SaveProcessingFileToDB(fileName, dbPath);


                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
                uploaded = true;

            }

            else
            {
                uploaded = false;

            }
            return uploaded;




        }
    }
}
