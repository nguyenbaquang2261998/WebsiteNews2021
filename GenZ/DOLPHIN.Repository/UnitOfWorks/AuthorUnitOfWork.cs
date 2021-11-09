// <copyright file="AuthorUnitOfWork.cs" company="PlaceholderCompany">
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
    public class AuthorUnitOfWork : UnitOfWorkBase, IAuthorUnitOfWork
    {
        private IAuthorRepository authorRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorUnitOfWork"/> class.
        /// </summary>
        /// <param name="dbcontext">.</param>
        public AuthorUnitOfWork(IDbContext dbcontext)
            : base(dbcontext)
        {
        }

        /// <inheritdoc/>
        public IAuthorRepository AuthorRepository => this.authorRepository ?? (this.authorRepository = new AuthorRepository(this.dbContext));
    }
}
