using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Common.Interfaces
{
    public interface IEntityService<T> : IService
    {
        /// <summary>
        /// Create an entity.
        /// </summary>
        /// <param name="entity">T.</param>
        /// <returns>Created Entity.</returns>
        Task<T> Create(T entity);

        /// <summary>
        /// Delete entity.
        /// </summary>
        /// <param name="entity">T.</param>
        /// <returns>true if delete successfully, otherwise return false.</returns>
        Task<bool> Delete(T entity);

        /// <summary>
        /// Get all entities.
        /// </summary>
        /// <returns>IEnumerable T.</returns>
        Task<IEnumerable<T>> GetAll();

        /// <summary>
        /// Update entity.
        /// </summary>
        /// <param name="entity">T.</param>
        /// <returns>true if update successfully, otherwise return false.</returns>
        Task<bool> Update(T entity);
    }
}
