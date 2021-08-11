using DOLPHIN.DTO;
using DOLPHIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Interfaces
{
    public interface IArticleService
    {
        Task<List<News>> GetAll();
        Task<List<News>> Search(ArticleSearchDto searchDto);
        Task<News> GetArticleById(int id);
        Task<bool> CreateArticles(ArticlesDto articles);
    }
}
