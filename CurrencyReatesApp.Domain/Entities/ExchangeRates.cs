namespace CurrencyReatesApp.Domain.Entities
{
    public class ExchangeRates
    {
        public string Date { get; set; }
        public string Currency { get; set; }
        public string Quantity { get; set; }
        public string Rate { get; set; }
        public string Unit { get; set; }
    }
}
