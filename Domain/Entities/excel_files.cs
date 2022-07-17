using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class excel_files
    {
        [Key]
        public int ID { get; set; }

        public string file_name { get; set; }

        public string file_path { get; set; }

        public DateTime inserted_date { get; set; }




    }
}
