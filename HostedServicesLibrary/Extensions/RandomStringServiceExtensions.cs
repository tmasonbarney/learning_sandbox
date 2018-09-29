using HostedServicesLibrary.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HostedServicesLibrary.Extensions
{
    public static class RandomStringServiceExtensions
    {
        public static IServiceCollection AddRandomStringService(this IServiceCollection  services)
        {
            services.AddHostedService<RandomStringService>();
            return services;
        }
    }
}
