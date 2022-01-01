using AutoMapper;
using DOLPHIN.Exceptions;
using DOLPHIN.Model;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;
using DOLPHIN.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryUnitOfWork categoryUnitOfWork;
        private readonly IMapper mapper;

        public CategoriesService(ICategoryUnitOfWork categoryUnitOfWork, IMapper mapper)
        {
            this.categoryUnitOfWork = categoryUnitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<Category>> GetAll()
        {
            List<Category> categories = new List<Category>();
            categories = (await this.categoryUnitOfWork.CategoryRepository.GetAll()).ToList();

            return categories;
        }

        public async Task<Category> GetById(int id)
        {
            Category category = new Category();
            category = (await this.categoryUnitOfWork.CategoryRepository.FindBy(x => x.Id == id)).FirstOrDefault();
            return category;
        }

        public async Task<bool> CreateCategories(Category category)
        {
            if (category == null || category.Id <= 0 || string.IsNullOrEmpty(category.Name)) {
                return false;
            }

            await this.categoryUnitOfWork.CategoryRepository.Add(this.mapper.Map<Category>(category));

            return await this.categoryUnitOfWork.Commit() > 0;
        }

        public async Task<bool> UpdateCategories(Category requestData)
        {
            if (requestData == null || requestData.Id <= 0 || string.IsNullOrEmpty(requestData.Name)) {
                return false;
            }

            var categories = (await this.categoryUnitOfWork.CategoryRepository.FindBy(x => x.Id == requestData.Id)).FirstOrDefault();

            if (categories == null) {
                return false;
            }

            categories.Name = requestData.Name;
            categories.Description = requestData.Description;

            await this.categoryUnitOfWork.CategoryRepository.Edit(categories);
            return await this.categoryUnitOfWork.Commit() > 0;
        }

        public async Task<bool> DeleteCategories(int id)
        {
            if (id <= 0) {
                return false;
            }
            var categories = (await this.categoryUnitOfWork.CategoryRepository.FindBy(x => x.Id == id)).FirstOrDefault();
            if (categories == null) {
                return false;
            }
            await this.categoryUnitOfWork.CategoryRepository.Delete(categories);
            return await this.categoryUnitOfWork.Commit() > 0;
        }
    }
}
