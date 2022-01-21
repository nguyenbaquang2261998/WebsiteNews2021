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
        public bool AvgPriceChange { get; set; }
        public bool MarketCap { get; set; }
        public bool MarketCapChange { get; set; }
        public bool Volume { get; set; }
        public bool Volume_change { get; set; }
        public bool VolumeChange { get; set; }
        public long LastUpdated { get; set; }
    }
}
