using DOLPHIN.DTO;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;
using DOLPHIN.Service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticlesController : Controller
    {
        private readonly IArticleService articleService;
        private readonly INewsUnitOfWork newsUnitOfWork;
        [Obsolete]
        private readonly IHostingEnvironment environment;

        [Obsolete]
        public ArticlesController(IArticleService articleService, INewsUnitOfWork newsUnitOfWork, IHostingEnvironment environment)
        {
            this.articleService = articleService;
            this.newsUnitOfWork = newsUnitOfWork;
            this.environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await this.articleService.GetAll();
            ViewBag.TotalRecord = articles.Count();
            return View(articles);
        }

        // HTTP: GET
        public async Task<IActionResult> Create()
        {
            ViewBag.ListCategories = new SelectList((await this.newsUnitOfWork.CategoryRepository.GetAll()).ToList(), "Id", "Name");
            ViewBag.ListAuthors = new SelectList((await this.newsUnitOfWork.AuthorRepository.GetAll()).ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> Create(ArticlesDto article, IFormFile file)
        {
            if (file.Length > 0)
            {
                string fileName = file.FileName;
                //Get the extension of the file
                string extension = Path.GetExtension(fileName);
                //check the file extension as png
                if (extension == ".png" || extension == ".jpg")
                {
                    //set the path where file will be copied
                    string wwwPath = this.environment.WebRootPath;
                    string filePath = wwwPath + "\\upload";
                    //copy the file to the path
                    using (var fileStream = new FileStream(
                        Path.Combine(filePath, fileName),
                                       FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                article.CoverImage = fileName;
            }
            
            var result = await this.articleService.CreateArticles(article);
            if (result)
            {
                return Redirect("/admin/articles");
            }
            return View();
        }
        public async Task<IActionResult> Update(int id)
        {
            ViewBag.ListCategories = new SelectList((await this.newsUnitOfWork.CategoryRepository.GetAll()).ToList(), "Id", "Name");
            ViewBag.ListAuthors = new SelectList((await this.newsUnitOfWork.AuthorRepository.GetAll()).ToList(), "Id", "Name");
            var article = await this.articleService.GetArticleDto(id);
            return View(article);
        }

        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> Update(ArticlesDto articlesDto, IFormFile file)
        {
            if (articlesDto.Id > 0)
            {
                var article = await this.articleService.GetArticleById(articlesDto.Id);
                if (file != null)
                {
                    if (file.Length > 0 && file.FileName != article.CoverImage)
                    {
                        string fileName = file.FileName;
                        //Get the extension of the file
                        string extension = Path.GetExtension(fileName);
                        //check the file extension as png
                        if (extension == ".png" || extension == ".jpg")
                        {
                            //set the path where file will be copied
                            string wwwPath = this.environment.WebRootPath;
                            string filePath = wwwPath + "\\upload";
                            //copy the file to the path
                            using (var fileStream = new FileStream(
                                Path.Combine(filePath, fileName),
                                               FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                            }
                        }
                        articlesDto.CoverImage = fileName;
                    }
                }
                else
                {
                    articlesDto.CoverImage = article.CoverImage;
                }
            }

            var result = await this.articleService.UpdateArticles(articlesDto);
            if (result)
            {
                return Redirect("/admin/articles");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await this.articleService.DeleteArticles(id);
            if (result)
            {
                return Json(new { status = 1, message = "Xóa thành công" });
            }
            return Json(new { status = 0, message = "Xóa thất bại" });
        }
        public IActionResult Search()
        {
            return View();
        }
    }
}
