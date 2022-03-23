using DOLPHIN.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Helpers.Interfaces
{
    public interface ICoinMarketCapHelper
    {
        Task<string> GetCryptoCurrency();
        Task<string> ListingsLatest(FillterDto fillter);
    }
}
