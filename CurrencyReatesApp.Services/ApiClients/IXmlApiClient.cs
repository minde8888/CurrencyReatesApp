using CurrencyReatesApp.Domain.Entities;

namespace CurrencyReatesApp.Services.ApiClients
{
    public interface IXmlApiClient
    {
        public Task<ExchangeRates> ExchangeData(string date);
    }
}
