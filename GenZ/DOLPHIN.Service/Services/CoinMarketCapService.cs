using DOLPHIN.DTO;
using DOLPHIN.Helpers.Interfaces;
using DOLPHIN.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DOLPHIN.Helpers.Enums;

namespace DOLPHIN.Service.Services
{
    public class CoinMarketCapService : ICoinMarketCapService
    {
        private readonly ICoinMarketCapHelper coinMarketCapHelper;

        public CoinMarketCapService(ICoinMarketCapHelper coinMarketCapHelper)
        {
            this.coinMarketCapHelper = coinMarketCapHelper;
        }

        public async Task<List<CryptoCurrencyCategories>> GetCryptoCurrencyCategories()
        {
            var response = await this.coinMarketCapHelper.GetCryptoCurrency();
            List<CryptoCurrencyCategories> categories = new List<CryptoCurrencyCategories>();
            if (response != null) {
                var result = JsonConvert.DeserializeObject<dynamic>(response);
                if (result != null && result.status.error_code == (int)EnApiStatusCode.Success) {
                    foreach (var item in result?.data) {
                        CryptoCurrencyCategories cryptoCategory = new CryptoCurrencyCategories()
                        {
                            Id = item.id,
                            Name = item.name,
                            Title = item.title,
                            Description = item.description,
                            NumTokens = item.num_tokens,
                            AvgPriceChange = item.avg_price_change,
                            MarketCap = item.market_cap,
                            MarketCapChange = item.market_cap_change,
                            Volume = item.volume,
                            VolumeChange = item.volume_change,
                            LastUpdated = item.last_updated
                        };
                        categories.Add(cryptoCategory);
                    }
                }
                return categories;
            }

            return categories;
        }
    }
}
