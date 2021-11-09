// <copyright file="ICategoryUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;

    /// <summary>
    /// Interface NewsUnitOfWork.
    /// </summary>
    public interface ICategoryUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets newsRepository.
        /// </summary>
        ICategoryRepository CategoryRepository { get; }
    }
}
