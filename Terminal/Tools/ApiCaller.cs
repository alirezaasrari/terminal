namespace ConsoleApp
{
    class Program
    {
#pragma warning disable IDE0051 // Remove unused private members
        private static async Task Test()
#pragma warning restore IDE0051 // Remove unused private members
        {
            var url = "https://localhost:7207/api/Terminal/terminaldata/4002810018";

            try
            {
                // Handle potential SSL issues
                using var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (request, cert, chain, errors) =>
                {
                    // Customize certificate validation logic here
                    // For testing, you can temporarily return true to trust all certificates,
                    // but this is not recommended for production environments.
                    return true; // Replace with appropriate validation for production
                };

                using var client = new HttpClient(handler);

                // Make the HTTP request
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    //await stream.WriteAsync(Encoding.UTF8.GetBytes(data));
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine("Request failed with status code: {0}", response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
/*
 * this is a code suggested for the fetch server
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataReceiverServer
{
    public class DataFetcherService : IHostedService, IDisposable
    {
        private readonly ILogger<DataFetcherService> _logger;
        private readonly HttpClient _httpClient;
        private Timer _timer;

        public DataFetcherService(ILogger<DataFetcherService> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(FetchData, null, TimeSpan.Zero, TimeSpan.FromMinutes(5)); // Fetch every 5 minutes
            return Task.CompletedTask;
        }

        private async void FetchData(object state)
        {
            try
            {
                var response = await _httpClient.GetAsync("https://externalapi.com/data");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    // Process the received data
                    _logger.LogInformation("Received data: {data}", data);
                }
                else
                {
                    _logger.LogError("Failed to fetch data: {statusCode}", response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching data: {message}", ex.Message);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
            _httpClient.Dispose();
        }
    }
}
 */ 