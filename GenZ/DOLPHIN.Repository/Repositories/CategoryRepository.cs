// <copyright file="CategoryRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DOLPHIN.Repository.Repositories
{
    using DOLPHIN.Model;
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;

    /// <summary>
    /// News Repository.
    /// </summary>
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        /// <param name="context">.</param>
        public CategoryRepository(IDbContext context)
            : base(context)
        {
        }
    }
}
