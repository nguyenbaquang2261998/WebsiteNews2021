// <copyright file="NewsRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DOLPHIN.Model;
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;

    /// <summary>
    /// News Repository.
    /// </summary>
    public class NewsRepository : GenericRepository<News>, INewsRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewsRepository"/> class.
        /// </summary>
        /// <param name="context">.</param>
        public NewsRepository(IDbContext context)
            : base(context)
        {
        }
    }
}
