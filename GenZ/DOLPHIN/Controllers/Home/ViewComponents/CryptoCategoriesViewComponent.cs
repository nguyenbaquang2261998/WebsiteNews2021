using DOLPHIN.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers.Home.ViewComponents
{
    public class CryptoCategoriesViewComponent : ViewComponent
    {
        private readonly ICoinMarketCapService coinMarketCapService;

        public CryptoCategoriesViewComponent(ICoinMarketCapService coinMarketCapService)
        {
            this.coinMarketCapService = coinMarketCapService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cryptoCategories = await this.coinMarketCapService.GetCryptoCurrencyCategories();
            return View(cryptoCategories);
        }
    }
}
