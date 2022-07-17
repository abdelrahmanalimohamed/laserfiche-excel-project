using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Business_Logic
{
    public interface IUploadExcel
    {
        public  Task<bool> UploadFile(IFormFile formFile );

    }
}
