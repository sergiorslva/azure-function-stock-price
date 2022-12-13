using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using StockMarket.Models;
using StockMarket.Providers;

namespace StockMarket.Functions
{
    public class GetStockFunction
    {
        private readonly ILogger _logger;
        private readonly IStockQuoteDataProvider _stockQuoteDataProvider;

        public GetStockFunction(
            IStockQuoteDataProvider stockQuoteDataProvider, 
            ILoggerFactory loggerFactory
        )
        {
            _logger = loggerFactory.CreateLogger<GetStockFunction>();
            _stockQuoteDataProvider = stockQuoteDataProvider;
        }

        [Function("stock-quote")]
        public async Task<StockQuoteModel> Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous, 
                "get",
                Route = "stock-quote/symbol/{symbol}"
            )]
            HttpRequestData req,
            string symbol
        )
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var stockQuote = await _stockQuoteDataProvider.GetStockDataForSymbolAsync(symbol);
            return stockQuote;            
        }
    }
}
