namespace CurrencyReatesApp.Domain.Exceptions
{
    public class XmlNotFoundException : Exception
    {
        public XmlNotFoundException() : base("XML dos't exist in this request")
        {
        }
    }
}
