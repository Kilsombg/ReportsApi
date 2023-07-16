using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsData
{
    public static class ConfigureReportsServices
    {
        public static IServiceCollection AddReportsServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddScoped<IReportsContext, ReportsContext>();

            services.AddDbContext<ReportsContext>((sp, options) =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
