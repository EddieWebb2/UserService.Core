using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace UserService.Core
{
    public class Worker: BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient _client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;


            // We dont need the environment switch anymore!
            // when debugging this will automatically run in console mode, but when deployed will run as service! Cool
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _client = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //_logger.LogInformation($"Worker running at: {DateTime.Now}");

                var result = await _client.GetAsync("https://www.matchtech.com");

                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
