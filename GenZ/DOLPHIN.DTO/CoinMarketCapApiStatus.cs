using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class CoinMarketCapApiStatus
    {
        public string Timestamp { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public int Elapsed { get; set; }
        public int CreditCount { get; set; }
    }
}
