using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class admin_departments
    {
        [Key]
        public string id { get; set; }

        public string name { get; set; }

        //public string _id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //public string _name {
        //    get { return name; }
        //    set { name = value; } 
        //}


    }
}
