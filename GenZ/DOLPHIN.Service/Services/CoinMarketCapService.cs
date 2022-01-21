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
                if (result != null && result.status.error == EnApiStatusCode.Success) {
                    
                    foreach (var item in response) {

                    }
                }
                return await result;
            }

            return categories;
        }
    }
}
