using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Business_Logic
{
    public interface IReadExcelSheets
    {
        //  public  Task<List<List<string>>> ExcelSheets();


        public Task<string> FilePath();
        // public Task <List<Sheets>> ExcelSheets();


        public Task<DataSet> ReadExcelSheet();
    }
}
