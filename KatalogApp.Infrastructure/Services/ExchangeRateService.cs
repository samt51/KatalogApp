using KatalogApp.Application.Interfaces.Services;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KatalogApp.Infrastructure.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly HttpClient _httpClient;
        private static decimal? _cachedPrice = null;
        private static DateTime _lastFetchTime = DateTime.MinValue;

        public ExchangeRateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            if (_httpClient.Timeout.TotalSeconds > 10)
            {
                _httpClient.Timeout = TimeSpan.FromSeconds(5);
            }
        }

        public async Task<decimal> GetHasAltinPriceAsync()
        {
            if (_cachedPrice.HasValue && (DateTime.Now - _lastFetchTime).TotalMinutes < 5)
            {
                return _cachedPrice.Value;
            }

            try
            {


                var response = await _httpClient.GetAsync("https://pusulanet.net/kurlar/pusula.txt");
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<DailyCureDataDto.Root>(jsonString);
                if (result != null && result.data != null)
                {
                    decimal altinSatis = result.data.ALTIN?.satis ?? 0;
                    decimal usdTrySatis = result.data.USDTRY?.satis ?? 0;

                    if (altinSatis > 0 && usdTrySatis > 0)
                    {
                        // Altın'ın TL satış fiyatını Dolar'ın TL satış fiyatına bölerek
                        // 1 Gram Has Altının USD cinsinden fiyatını buluyoruz.
                        decimal hasPrice = altinSatis / usdTrySatis;


                        _cachedPrice = hasPrice;
                        _lastFetchTime = DateTime.Now;
                        return hasPrice;
                    }
                }


                return _cachedPrice ?? 145m; // 145 USD/gram fallback based on 2026 data
            }
            catch
            {
                if (!_cachedPrice.HasValue)
                {
                    _cachedPrice = 145m; // 145 USD/gram fallback based on 2026 data
                }
                _lastFetchTime = DateTime.Now; // Cache the failed state so we don't spam timeouts
                return _cachedPrice.Value;
            }
        }

        public class DailyCureDataDto
        {
            public class Root
            {
                [JsonPropertyName("meta")]
                public Meta meta { get; set; } = new();

                [JsonPropertyName("data")]
                public Data data { get; set; } = new();
            }

            public class Meta
            {
                [JsonPropertyName("time_formatted")]
                public string time_formatted { get; set; } = string.Empty;
            }

            public class Data
            {
                [JsonPropertyName("ALTIN")]
                public CurrencyData ALTIN { get; set; } = new();

                [JsonPropertyName("USDTRY")]
                public CurrencyData USDTRY { get; set; } = new();

                [JsonPropertyName("EURTRY")]
                public CurrencyData EURTRY { get; set; } = new();

                [JsonPropertyName("GBPTRY")]
                public CurrencyData GBPTRY { get; set; } = new();

                [JsonPropertyName("CHFTRY")]
                public CurrencyData CHFTRY { get; set; } = new();

                [JsonPropertyName("SARTRY")]
                public CurrencyData SARTRY { get; set; } = new();

                [JsonPropertyName("GUMUSTRY")]
                public CurrencyData GUMUSTRY { get; set; } = new();

                [JsonPropertyName("XAUUSDS")]
                public CurrencyData XAUUSDS { get; set; } = new();

                [JsonPropertyName("EURUSD")]
                public CurrencyData EURUSD { get; set; } = new();
            }

            public class CurrencyData
            {
                [JsonPropertyName("code")]
                public string code { get; set; } = string.Empty;

                [JsonPropertyName("alis")]
                public decimal alis { get; set; }

                [JsonPropertyName("satis")]
                public decimal satis { get; set; }

                [JsonPropertyName("tarih")]
                public string tarih { get; set; } = string.Empty;
            }
        }
    }
}
