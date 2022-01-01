using DOLPHIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Interfaces
{
    public interface ICategoriesService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<bool> CreateCategories(Category category);
        Task<bool> UpdateCategories(Category requestData);
        Task<bool> DeleteCategories(int id);
    }
}
