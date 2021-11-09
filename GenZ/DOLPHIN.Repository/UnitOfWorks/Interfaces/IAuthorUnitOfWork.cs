// <copyright file="IAuthorUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;

    /// <summary>
    /// Interface NewsUnitOfWork.
    /// </summary>
    public interface IAuthorUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets newsRepository.
        /// </summary>
        IAuthorRepository AuthorRepository { get; }
    }
}
