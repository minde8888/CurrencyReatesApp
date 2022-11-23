using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurrencyReatesApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _userService.SearchAsync(name);
            return Ok(result);
        }
    }
}
