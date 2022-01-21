using DOLPHIN.Helpers.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Helpers.Helpers
{
    public class CoinMarketCapHelper : ICoinMarketCapHelper
    {
        private readonly IConfiguration configs;
        private readonly string coinMarketCapAPIUrl;
        private readonly string coinMarketCapValue;


        public CoinMarketCapHelper(IConfiguration configs)
        {
            this.configs = configs;
            this.coinMarketCapAPIUrl = this.configs["CoinMarketCapAPIUrl"];
            this.coinMarketCapValue = this.configs["CoinMarketCapValue"];

        }

        public async Task<string> GetCryptoCurrency()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(coinMarketCapAPIUrl);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("token", "98bb7369-1162-11eb-a23c-065c95c021cb");

            // List data response.
            string urlRequest = "/v1/cryptocurrency/categories?" + coinMarketCapValue;
            var response = await client.GetAsync(urlRequest);
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
