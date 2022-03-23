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

        /// <summary>
        /// Get Crypto Currency Categories.
        /// </summary>
        /// <returns>categories</returns>
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

        /// <summary>
        /// Listings Latest.
        /// </summary>
        /// <returns>Returns a paginated list of all active cryptocurrencies with latest market data</returns>
        public async Task<List<ListingsLastestDto>> ListingsLatest(FillterDto fillter)
        {
            var response = await this.coinMarketCapHelper.ListingsLatest(fillter);
            List<ListingsLastestDto> listingsLastests = new List<ListingsLastestDto>();
            if (response != null)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(response);
                QuoteDto cryptoCurrencyQuote = new QuoteDto();
                if (result != null && result.status.error_code == (int)EnApiStatusCode.Success)
                {
                    foreach (var item in result?.data?.cryptoCurrencyList)
                    {
                        foreach (var quote in item.quotes)
                        {
                            if (quote?.name == "USD")
                            {
                                cryptoCurrencyQuote.QuoteName = quote?.name;
                                cryptoCurrencyQuote.Price = quote?.price;
                                cryptoCurrencyQuote.Volume24h = quote?.volume24h;
                                cryptoCurrencyQuote.MarketCap = quote?.marketCap;
                                cryptoCurrencyQuote.PercentChange1h = quote?.percentChange1h;
                                cryptoCurrencyQuote.PercentChange24h = quote?.percentChange24h;
                                cryptoCurrencyQuote.PercentChange7d = quote?.percentChange7d;
                                cryptoCurrencyQuote.LastUpdated = quote?.lastUpdated;
                                cryptoCurrencyQuote.MarketCapDominance = quote?.dominance;
                                cryptoCurrencyQuote.FullyDiluted = quote?.fullyDilluttedMarketCap;
                            }
                        }

                        ListingsLastestDto listing = new ListingsLastestDto()
                        {
                            Id = item.id,
                            Name = item.name,
                            Symbol = item.symbol,
                            Slug = item.slug,
                            CmcRank = item.cmcRank,
                            NumMarketPairs = item.marketPairCount,
                            CirculatingSupply = item.circulatingSupply,
                            TotalSupply = item.totalSupply,
                            MaxSupply = item.maxSupply,
                            IsActive = item.isActive,
                            DateAdded = item.dateAdded,
                            Quote = cryptoCurrencyQuote
                        };
                        listingsLastests.Add(listing);
                    }
                }
                return listingsLastests;
            }

            return listingsLastests;
        }
    }
}
