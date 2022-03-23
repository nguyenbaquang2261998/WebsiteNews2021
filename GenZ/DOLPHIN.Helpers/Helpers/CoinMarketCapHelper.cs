using DOLPHIN.DTO;
using DOLPHIN.Helpers.Enums;
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

        /// <summary>
        /// GetCryptoCurrency
        /// </summary>
        /// <returns>Returns information about all coin categories available on CoinMarketCap. Includes a paginated list of cryptocurrency quotes and metadata from each category.</returns>
        public async Task<string> GetCryptoCurrency()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(coinMarketCapAPIUrl);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("token", "98bb7369-1162-11eb-a23c-065c95c021cb");

            // List data response.
            string urlRequest = "cryptocurrency/categories";
            var response = await client.GetAsync(urlRequest);
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }

        /// <summary>
        /// Listings Latest.
        /// </summary>
        /// <returns>Returns a paginated list of all active cryptocurrencies with latest market data</returns>
        public async Task<string> ListingsLatest(FillterDto fillter)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(coinMarketCapAPIUrl);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            string urlDefault = "/v3/cryptocurrency/listing?";
            StringBuilder urlRequest = new StringBuilder().Append(urlDefault) ;
            if (fillter.Start > 0 && fillter.Limit > 0)
            {
                urlRequest.AppendFormat("start={0}&limit={1}", fillter.Start, fillter.Limit);
            }
            if (fillter.SortBy == (int)EnSortBy.Rank)
            {
                urlRequest.Append("&sortBy=rank");
            }
            if (fillter.SortType == (int)EnSortType.DESC)
            {
                urlRequest.Append("&sortType=desc");
            }
            var response = await client.GetAsync(urlRequest.ToString());
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
