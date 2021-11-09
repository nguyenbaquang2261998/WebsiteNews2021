using AutoMapper;
using DOLPHIN.DTO;
using DOLPHIN.Exceptions;
using DOLPHIN.Helpers.Enums;
using DOLPHIN.Model;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;
using DOLPHIN.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Services
{
    public class ArticlesService : IArticleService
    {
        private readonly INewsUnitOfWork newsUnitOfWork;
        private readonly IMapper mapper;
        public ArticlesService(INewsUnitOfWork newsUnitOfWork, IMapper mapper)
        {
            this.newsUnitOfWork = newsUnitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<News>> GetAll()
        {
            var articles = (await this.newsUnitOfWork.NewsRepository.GetAll())
                .Include(x => x.Author)
                .Include(x => x.Category)
                .ToList();
            if (articles == null)
            {
                articles = new List<News>();
            }
            return articles;
        }

        public async Task<News> GetArticleLastest()
        {
            var articles = (await this.newsUnitOfWork.NewsRepository.GetAll())
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x => x.CreatedDate)
                .FirstOrDefault();

            return articles;
        }

        public async Task<bool> CreateArticles(ArticlesDto articles)
        {
            if (articles == null)
            {
                throw new DolphinException(ErrorCode.ArgumentInvalid, nameof(articles));
            }
            if (articles.CategoryId <= 0 || string.IsNullOrEmpty(articles.Title) || articles.AuthorId <= 0 || string.IsNullOrEmpty(articles.Content) || string.IsNullOrEmpty(articles.CoverImage))
            {
                throw new DolphinException(ErrorCode.ArgumentInvalid, nameof(articles));
            }
            articles.CreatedDate = DateTime.Now;
            articles.UpdatedDate = DateTime.Now;
            articles.Status = (int)EnArticleStatus.Approved;
            await this.newsUnitOfWork.NewsRepository.Add(this.mapper.Map<News>(articles));
            return await this.newsUnitOfWork.Commit() > 0;
        }
        public async Task<bool> UpdateArticles(ArticlesDto articles)
        {
            if (articles == null)
            {
                throw new DolphinException(ErrorCode.ArgumentInvalid, nameof(articles));
            }
            if (articles.CategoryId <= 0 || string.IsNullOrEmpty(articles.Title) || articles.AuthorId <= 0 || string.IsNullOrEmpty(articles.Content) || string.IsNullOrEmpty(articles.CoverImage))
            {
                throw new DolphinException(ErrorCode.ArgumentInvalid, nameof(articles));
            }
            var newsModel = (await this.newsUnitOfWork.NewsRepository.FindBy(x => x.Id == articles.Id)).FirstOrDefault();
            if (newsModel == null)
            {
                throw new DolphinException(ErrorCode.AritclesNotFound, nameof(articles));
            }
            newsModel.Title = articles.Title;
            newsModel.Content = articles.Content;
            newsModel.AuthorId = articles.AuthorId;
            newsModel.UpdatedDate = DateTime.Now;
            newsModel.CoverImage = articles.CoverImage;
            await this.newsUnitOfWork.NewsRepository.Edit(newsModel);
            return await this.newsUnitOfWork.Commit() > 0;
        }

        public async Task<List<News>> Search(ArticleSearchDto searchDto)
        {
            if (searchDto == null)
            {
                throw null;
            }
            if (searchDto.ArticleId <= 0)
            {
                throw null;
            }
            var result = await this.GetArticleByAuthorName(searchDto.AuthorName);
            return result;
        }

        public async Task<bool> DeleteArticles(int id)
        {
            if (id <= 0)
            {
                throw new DolphinException(ErrorCode.ArgumentInvalid, nameof(id));
            }
            var article = (await this.newsUnitOfWork.NewsRepository.FindBy(x => x.Id == id)).FirstOrDefault();
            if (article == null)
            {
                throw new DolphinException(ErrorCode.AritclesNotFound, nameof(article));
            }
            await this.newsUnitOfWork.NewsRepository.Delete(article);
            return await this.newsUnitOfWork.Commit() > 0;
        }

        public async Task<ArticlesDto> GetArticleDto(int id)
        {
            if (id <= 0)
            {
                throw null;
            }
            var article = (await this.newsUnitOfWork.NewsRepository.FindBy(x => x.Id == id)).FirstOrDefault();
            var articlesDto = this.mapper.Map<ArticlesDto>(article);
            return articlesDto;
        }

        public async Task<News> GetArticleById(int id)
        {
            if (id <= 0)
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
