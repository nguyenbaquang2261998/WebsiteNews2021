using DOLPHIN.Model;
using DOLPHIN.Service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DOLPHIN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        [Obsolete]
        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            var lstCategories = await this.categoriesService.GetAll();
            return View(lstCategories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            var result = await this.categoriesService.CreateCategories(category);
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            var result = await this.categoriesService.UpdateCategories(category);
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await this.categoriesService.DeleteCategories(id);
            if (result) {
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
