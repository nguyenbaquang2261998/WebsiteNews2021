using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DOLPHIN.Models;
using DOLPHIN.Model;
using DOLPHIN.Service.Interfaces;

namespace DOLPHIN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;
        public HomeController(ILogger<HomeController> logger, IArticleService articleService)
        {
            _logger = logger;
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            // Get article lastest.
            ViewBag.ArticlesLastest = await this.articleService.GetArticleLastest();
            return View();
        }

        public async Task<IActionResult> GetArticleMain()
        {
            var articles = (await this.articleService.GetAll()).FirstOrDefault();
            return View(articles);
        }

        public async Task<IActionResult> Details(int id)
        {
            var article = await this.articleService.GetArticleById(id);
            return View(article);
        }
    }
}
