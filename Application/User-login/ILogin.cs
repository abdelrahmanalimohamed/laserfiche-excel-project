using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User_login
{
    public interface ILogin
    {
        public admin_users LoginUser(string username , string password);
    }
}
