using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class ListingsLastestDto
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int CmcRank { get; set; }
        public int NumMarketPairs { get; set; }
        public int CirculatingSupply { get; set; }
        public int TotalSupply { get; set; }
        public int MaxSupply { get; set; }
        public int High24h { get; set; }
        public int Low24h { get; set; }
        public int IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public QuoteDto Quote { get; set; }

    }
}
