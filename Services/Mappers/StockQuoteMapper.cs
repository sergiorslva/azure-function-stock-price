using StockMarket.Models;

namespace StockMarket.Services.Mappers
{
    public static class StockQuoteMapper
    {
        public static StockQuoteModel Convert(QuoteModel quoteModel)
        {
            return new StockQuoteModel
            {
                Current = quoteModel.c,
                High = quoteModel.h,
                Low = quoteModel.l,
                Open = quoteModel.o,
                PreviousClose = quoteModel.pc
            };
        }
    }
}
