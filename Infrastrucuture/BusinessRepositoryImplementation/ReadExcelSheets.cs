using Application.Business_Logic;
using Syncfusion.XlsIO;
using System.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;
using Domain.DTO;
using Infrastrucuture.Persistence;

namespace Infrastrucuture.BusinessRepositoryImplementation
{
    public class ReadExcelSheets : IReadExcelSheets
    {
     

        private readonly ExcelDbContext excelDbContext;
        private readonly DataSet dataSet;
    
        public ReadExcelSheets()
        {
            dataSet = new DataSet();
        
        }

        public ReadExcelSheets(ExcelDbContext excelDb) : this()
        {
            excelDbContext = excelDb;
            
        }

       
        public async Task<string> FilePath()
        {
            var lastid = (from a in excelDbContext.excel_Files_processing
                          select a.ID).Max();

            var file_path = await Task.Run(() =>( from b in excelDbContext.excel_Files_processing
                                   where b.ID == lastid
                                   select b.file_path).FirstOrDefault());

            return file_path;
        }


        #region NewCode

        public async Task<DataSet> ReadExcelSheet()
        {
            string file_path = await FilePath();
            WorkBook wb =  WorkBook.Load(file_path);

            for (int i = 0; i < wb.WorkSheets.Count; i++)
            {

                 WorkSheet workingsheet = wb.WorkSheets[i];
                dataSet.Tables.Add(workingsheet.ToDataTable(true));

                 
            }


          


            return dataSet;
        }
        #endregion







    }
}
