using StockMarket.Models;

namespace StockMarket.Providers
{
    public interface IStockQuoteDataProvider
    {
        public Task<StockQuoteModel> GetStockDataForSymbolAsync(string symbol);
    }
}
