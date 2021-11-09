// <copyright file="INewsUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;

    /// <summary>
    /// Interface NewsUnitOfWork.
    /// </summary>
    public interface INewsUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets newsRepository.
        /// </summary>
        INewsRepository NewsRepository { get; }

        /// <summary>
        /// Gets authorRepository.
        /// </summary>
        IAuthorRepository AuthorRepository { get; }

        /// <summary>
        /// Gets CategoryRepository.
        /// </summary>
        ICategoryRepository CategoryRepository { get; }
    }
}
