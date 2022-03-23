using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class QuoteDto
    {
        public string QuoteName { get; set; }
        public int Price { get; set; }
        public int Volume24h { get; set; }
        public int VolumeChange24h { get; set; }
        public int PercentChange1h { get; set; }
        public int PercentChange24h { get; set; }
        public int PercentChange7d { get; set; }
        public int MarketCap { get; set; }
        public int MarketCapDominance { get; set; }
        public int FullyDiluted { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
