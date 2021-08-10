using DOLPHIN.DTO;
using DOLPHIN.Model;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;
using DOLPHIN.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Services
{
    public class ArticlesSevice : IArticleService
    {
        private readonly INewsUnitOfWork newsUnitOfWork;
        public ArticlesSevice(INewsUnitOfWork newsUnitOfWork)
        {
            this.newsUnitOfWork = newsUnitOfWork;
        }

        public async Task<List<News>> GetAll()
        {
            var articles = (await this.newsUnitOfWork.NewsRepository.GetAll()).ToList();
            return articles;
        }

        public async Task<List<News>> Search(ArticleSearchDto searchDto)
        {
            if (searchDto == null)
            {
                throw null;
            }
            if (searchDto.ArticleId <= 0 )
            {
                throw null;
            }
            var result = await this.GetArticleByAuthorName(searchDto.AuthorName);
            return result;
        }

        public async Task<News> GetArticleById(int id)
        {
            if (id <= 0 )
            {
                throw null;
            }
            var article = (await this.newsUnitOfWork.NewsRepository.FindBy(x => x.Id == id)).FirstOrDefault();
            return article;
        }

        private async Task<List<News>> GetArticleByAuthorId(int authorId)
        {
            if (authorId <= 0)
            {
                throw null;
            }
            var articles = (await this.newsUnitOfWork.NewsRepository.FindBy(x => x.AuthorId == authorId)).ToList();
            return articles;
        }

        private async Task<List<News>> GetArticleByAuthorName(string authorName)
        {
            if (!string.IsNullOrEmpty(authorName))
            {
                throw null;
            }
            var articles = (await this.newsUnitOfWork.NewsRepository.FindBy(x => x.Author.DisplayName == authorName)).ToList();
            return articles;
        }
    }
}
