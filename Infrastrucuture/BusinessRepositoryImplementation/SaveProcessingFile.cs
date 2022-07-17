using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Application.Interfaces;
using Domain.Entities;
using Infrastrucuture.Persistence;

using System.Threading.Tasks;

namespace Infrastrucuture.BusinessRepositoryImplementation
{
    public class SaveProcessingFile : ISaveProcessingFile
    {

        private readonly ExcelDbContext excelDbContext;

        private readonly excel_files_processing excel_Files_Processing;


        public SaveProcessingFile(ExcelDbContext _excelDbContext)
        {
            excelDbContext = _excelDbContext;
            excel_Files_Processing = new excel_files_processing();
         
        }
       
       public async Task<int> SaveProcessingFileToDB(string file_name, string file_path)
        {
            excel_Files_Processing.file_name = file_name;
            excel_Files_Processing.file_path = file_path;
            excelDbContext.Add(excel_Files_Processing);
            var inserted_file = await  excelDbContext.SaveChangesAsync();

            return inserted_file;
        }
    }
}
