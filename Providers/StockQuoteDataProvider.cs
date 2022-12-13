using StockMarket.Models;
using StockMarket.Services.HttpClients;
using StockMarket.Services.Mappers;

namespace StockMarket.Providers
{
    public class StockQuoteDataProvider : IStockQuoteDataProvider
    {
        private readonly QuoteHttpClient _quoteHttpClient;

        public StockQuoteDataProvider(QuoteHttpClient quoteHttpClient)
        {
            this._quoteHttpClient = quoteHttpClient;
        }

        public async Task<StockQuoteModel> GetStockDataForSymbolAsync(string symbol)
        {
            var stockQuoteData = await _quoteHttpClient.GetStockQuoteForSymbolAsync(symbol);

            return StockQuoteMapper.Convert(stockQuoteData);
        }
    }
}
