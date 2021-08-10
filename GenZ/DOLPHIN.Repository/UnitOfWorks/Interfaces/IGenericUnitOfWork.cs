// <copyright file="IGenericUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
    using DOLPHIN.Repository.Common;

    /// <summary>
    /// IGenericUnitOfWork.
    /// </summary>
    /// <typeparam name="TInterface">TInterface</typeparam>
    public interface IGenericUnitOfWork<TInterface> : IUnitOfWork
    {
        /// <summary>
        /// Gets repository.
        /// </summary>
        TInterface Repository { get; }
    }
}
