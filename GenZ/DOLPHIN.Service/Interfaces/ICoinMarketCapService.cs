using DOLPHIN.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Interfaces
{
    public interface ICoinMarketCapService
    {
        Task<List<CryptoCurrencyCategories>> GetCryptoCurrencyCategories();
    }
}
