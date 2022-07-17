using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class admin_users
    {
        [Key]
        public Int16 id { get; set; }

        public string user_name { get; set; }

        public string full_name { get; set; }

        public string password { get; set; }

     

        public admin_departments departments { get; set; }


        


    }
}
