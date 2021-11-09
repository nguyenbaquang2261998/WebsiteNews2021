// <copyright file="NewsUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.UnitOfWorks
{
    using DOLPHIN.Model;
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;
    using DOLPHIN.Repository.Repositories;
    using DOLPHIN.Repository.UnitOfWorks.Interfaces;

    /// <summary>
    /// NewsUnitOfWork.
    /// </summary>
    public class NewsUnitOfWork : UnitOfWorkBase, INewsUnitOfWork
    {
        private INewsRepository newsRepository;
        private IAuthorRepository authorRepository;
        private ICategoryRepository categoryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsUnitOfWork"/> class.
        /// </summary>
        /// <param name="dbcontext">.</param>
        public NewsUnitOfWork(IDbContext dbcontext)
            : base(dbcontext)
        {
        }

        /// <inheritdoc/>
        public INewsRepository NewsRepository => this.newsRepository ?? (this.newsRepository = new NewsRepository(this.dbContext));

        /// <inheritdoc/>
        public IAuthorRepository AuthorRepository => this.authorRepository ?? (this.authorRepository = new AuthorRepository(this.dbContext));

        /// <inheritdoc/>
        public ICategoryRepository CategoryRepository => this.categoryRepository ?? (this.categoryRepository = new CategoryRepository(this.dbContext));
    }
}
