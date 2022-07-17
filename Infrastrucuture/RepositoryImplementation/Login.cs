using Application.User_login;
using Domain.Entities;
using Infrastrucuture.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucuture.Implementation
{
    public class Login : ILogin
    {
        private readonly ExcelDbContext GetExcelDbContext;
        public Login(ExcelDbContext excelDbContext)
        {
            GetExcelDbContext = excelDbContext;
        }
        public admin_users LoginUser(string username , string password)
        {

            //var userResult = GetExcelDbContext.users.FirstOrDefault(u => u.user_name == username & u.password == password);
            var userlogin = (from a in GetExcelDbContext.admin_users
                             where a.user_name == username && a.password == password
                             select a).FirstOrDefault();

            return userlogin;
                           
        }
    }
}
