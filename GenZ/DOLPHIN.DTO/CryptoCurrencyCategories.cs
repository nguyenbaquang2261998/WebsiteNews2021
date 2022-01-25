using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class CryptoCurrencyCategories : CoinMarketCapApiStatus
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumTokens { get; set; }
        public double AvgPriceChange { get; set; }
        public double MarketCap { get; set; }
        public double MarketCapChange { get; set; }
        public double Volume { get; set; }
        public double VolumeChange { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
