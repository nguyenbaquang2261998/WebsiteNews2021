// <copyright file="IUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.Common
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// IUnitOfWork.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Saves all pending changes.
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state.</returns>
        Task<int> Commit();
    }
}
