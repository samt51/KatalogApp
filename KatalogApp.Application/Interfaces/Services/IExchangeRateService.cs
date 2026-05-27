using System.Threading.Tasks;

namespace KatalogApp.Application.Interfaces.Services
{
    public interface IExchangeRateService
    {
        Task<decimal> GetHasAltinPriceAsync();
    }
}
