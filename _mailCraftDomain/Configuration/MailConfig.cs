using _mailCraftDomain.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _mailCraftDomain.Configuration
{
    public static class MailConfig
    {
        public static IServiceCollection AddMailServiceConfiguration(this IServiceCollection services,
                                                                                  IConfiguration configuration)
        {
            var mailServiceSettings = configuration.GetSection("MailServiceSettings");
            services.Configure<MailServiceSettings>(mailServiceSettings);

            return services;
        }
    }
}
