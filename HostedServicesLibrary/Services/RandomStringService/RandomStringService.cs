using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HostedServicesLibrary.Services
{
    public class RandomStringService : BackgroundService
    {
        private readonly ILogger<RandomStringService> _logger;

        public RandomStringService(ILogger<RandomStringService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug($"Random String Service Running");

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogDebug($"GracePeriod task doing background work.");

             
               // here we will run a randomstring generator called by RabbitMQ.

                await Task.Delay(100000, stoppingToken);
            }


        }
    }
}
