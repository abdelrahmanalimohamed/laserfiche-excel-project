using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucuture.Persistence
{
    public class ExcelDbContext : DbContext
    {


        public ExcelDbContext(DbContextOptions<ExcelDbContext> options) : base(options)
        {

        }

        public DbSet<admin_users> admin_users { get; set; }

        public DbSet<admin_departments> admin_departments { get; set; }

        public DbSet<excel_files_processing> excel_Files_processing { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder); 
        //}
    }
}
