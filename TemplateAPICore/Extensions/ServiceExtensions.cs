using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateAPICore.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
                options.AutomaticAuthentication = false;
                options.ForwardClientCertificate = false;
            });
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            //add scoped
        }

        public static void ConfigureSQLServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            // add connectionString connect db;
        }
    }
}
