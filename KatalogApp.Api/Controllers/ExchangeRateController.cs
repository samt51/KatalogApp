using KatalogApp.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly IExchangeRateService _exchangeRateService;

        public ExchangeRateController(IExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }

        [HttpGet("HasAltin")]
        [AllowAnonymous]
        public async Task<IActionResult> GetHasAltin()
        {
            var price = await _exchangeRateService.GetHasAltinPriceAsync();
            return Ok(new { price = price });
        }
    }
}
