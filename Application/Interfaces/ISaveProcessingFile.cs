using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISaveProcessingFile
    {
        public Task<int> SaveProcessingFileToDB(string file_name, string file_path);

      ///  public int SaveProcessingFileToDB(string file_name, string file_path);


    }
}
