using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockMarket.Providers;
using StockMarket.Services.HttpClients;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    {
        s.AddScoped<IStockQuoteDataProvider, StockQuoteDataProvider>();
        s.AddHttpClient<QuoteHttpClient>();
    })
    .Build();

host.Run();
