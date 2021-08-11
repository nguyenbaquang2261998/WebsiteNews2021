using DOLPHIN.DTO;
using DOLPHIN.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticlesController : Controller
    {
        private readonly IArticleService articleService;
        public ArticlesController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public IActionResult Index()
        {
            var articles = this.articleService.GetAll();
            return View(articles);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ArticlesDto article)
        {
            var result =  this.articleService.CreateArticles(article);
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
    }
}
