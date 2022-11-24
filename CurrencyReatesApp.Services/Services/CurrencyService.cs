using CurrencyReatesApp.Domain.Entities;
using CurrencyReatesApp.Domain.Exceptions;
using CurrencyReatesApp.Services.ApiClients;

namespace CurrencyReatesApp.Services.Services
{
    public class CurrencyService
    {
        private readonly IXmlApiClient _xmlApiClient;

        public CurrencyService(IXmlApiClient xmlApiClient)
        {
            _xmlApiClient = xmlApiClient;
        }

        public async Task<ExchangeRates> GetExchangeData(string date)
        {
            var result = await _xmlApiClient.ExchangeData(date);
            if (result == null)
            {
                throw new XmlNotFoundException();
            }
            return result;
        }
    }
}
