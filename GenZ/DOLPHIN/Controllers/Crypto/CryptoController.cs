using DOLPHIN.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class CryptoController : Controller
    {
        private readonly ICoinMarketCapService coinMarketCapService;

        public CryptoController(ICoinMarketCapService coinMarketCapService)
        {
            this.coinMarketCapService = coinMarketCapService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetCryptoCurrencyCategories()
        {
            var cryptoCategories = this.coinMarketCapService.GetCryptoCurrencyCategories();
            return PartialView("_CryptoCategories", cryptoCategories);
        }
    }
}
