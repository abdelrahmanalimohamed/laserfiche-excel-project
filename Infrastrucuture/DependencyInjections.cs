using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Infrastrucuture.Persistence;
using Microsoft.EntityFrameworkCore;
using Application.User_login;
using Infrastrucuture.Implementation;
using Application.Business_Logic;
using Infrastrucuture.BusinessRepositoryImplementation;
using Application.Interfaces;

namespace Infrastrucuture
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
             var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");
             services.AddDbContext<ExcelDbContext>(options =>options.UseSqlServer(defaultConnectionString));

             services.AddScoped<ILogin, Login>();
             services.AddScoped<IUploadExcel, UploadExcelFile>();
             services.AddScoped<IReadExcelSheets, ReadExcelSheets>();
             services.AddScoped<ISaveProcessingFile, SaveProcessingFile>();

            return services;
        }
    }
}
