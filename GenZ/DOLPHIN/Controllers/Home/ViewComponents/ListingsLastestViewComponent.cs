using DOLPHIN.DTO;
using DOLPHIN.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers.Home.ViewComponents
{
    public class ListingsLastestViewComponent : ViewComponent
    {
        private readonly ICoinMarketCapService coinMarketCapService;

        public ListingsLastestViewComponent(ICoinMarketCapService coinMarketCapService)
        {
            this.coinMarketCapService = coinMarketCapService;
        }

        public async Task<IViewComponentResult> InvokeAsync(FillterDto fillter)
        {
            var listingsLastests = await this.coinMarketCapService.ListingsLatest(fillter);
            return View(listingsLastests);
        }
    }
}
