using StockMarket.Models;
using System.Net.Http.Json;

namespace StockMarket.Services.HttpClients
{
    public class QuoteHttpClient
    {
        private readonly HttpClient _httpClient;

        public QuoteHttpClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("api_url"));
            httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", Environment.GetEnvironmentVariable("api_key"));

            this._httpClient = httpClient;
        }

        public async Task<QuoteModel> GetStockQuoteForSymbolAsync(string symbol)
        {
            var quotePath = $"quote?symbol={symbol}";

            var response = await _httpClient.GetAsync(quotePath);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<QuoteModel>();
        }
    }
}
