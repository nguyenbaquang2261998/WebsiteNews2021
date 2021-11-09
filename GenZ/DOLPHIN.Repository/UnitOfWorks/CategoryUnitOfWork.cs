// <copyright file="CategoryUnitOfWork.cs" company="PlaceholderCompany">
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
    public class CategoryUnitOfWork : UnitOfWorkBase, ICategoryUnitOfWork
    {
        private ICategoryRepository categoryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryUnitOfWork"/> class.
        /// </summary>
        /// <param name="dbcontext">.</param>
        public CategoryUnitOfWork(IDbContext dbcontext)
            : base(dbcontext)
        {
        }

        /// <inheritdoc/>
        public ICategoryRepository CategoryRepository => this.categoryRepository ?? (this.categoryRepository = new CategoryRepository(this.dbContext));
    }
}
