using CurrencyReatesApp.Domain.Entities;

namespace CurrencyReatesApp.Services.ApiClients
{
    public class XmlApiClient : IXmlApiClient
    {
        private readonly HttpClient _httpClient;
        public XmlApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ExchangeRates> ExchangeData(string date)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(date);
            var data = await response.Content.ReadAsStringAsync();
            XmlSerializer xmlserializer = new System.Xml.Serialization.XmlSerializer(data.GetType()); 

            var serializer = new XmlTextReader(data);
            var responseData = (ExchangeRates)xmlserializer.Deserialize(data);
            return null;
        }
    }
}
