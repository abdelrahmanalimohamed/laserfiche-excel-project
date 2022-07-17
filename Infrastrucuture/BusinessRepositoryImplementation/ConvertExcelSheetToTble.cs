using Application.Business_Logic;
using Infrastrucuture.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucuture.BusinessRepositoryImplementation
{
    public class ConvertExcelSheetToTble : IConvertExcelSheetToTble
    {
       private readonly ExcelDbContext GetExcelDbContext;

        public ConvertExcelSheetToTble(ExcelDbContext excelDbContext)
        {
            GetExcelDbContext = excelDbContext;
        }
       
        public void ConvertCheetToTble()
        {
            throw new NotImplementedException ();
        }
    }
}
