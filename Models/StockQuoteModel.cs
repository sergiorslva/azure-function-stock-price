namespace StockMarket.Models
{
    public class StockQuoteModel
    {
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Current { get; set; }
        public decimal PreviousClose { get; set; }
    }
}
