using CurrencyReatesApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyReatesApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : Controller
    {
        private readonly CurrencyService _currencyService;
        public CurrencyController(CurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string date)
        {
            var result = await _currencyService.GetExchangeData(date);
            return Ok(result);
        }
    }
}
