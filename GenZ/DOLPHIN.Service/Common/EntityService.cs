using DOLPHIN.Repository.Common;
using DOLPHIN.Service.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Common
{
    /// <summary>
    /// EntityService.
    /// </summary>
    /// <typeparam name="T">Entity model.</typeparam>
    public abstract class EntityService<T> : IEntityService<T>
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IGenericRepository<T> repository;

        /// <summary>
        /// Initialises a new instance of the <see cref="EntityService{T}"/> class.
        /// </summary>
        /// <param name="unitOfWork">IUnitOfWork.</param>
        /// <param name="repository">IGenericRepository.</param>
        protected EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        /// <inheritdoc />
        public virtual async Task<T> Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var result = await this.repository.Add(entity);
            return (await this.unitOfWork.Commit()) > 0 ? result : default(T);
        }

        /// <inheritdoc />
        public virtual async Task<bool> Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await this.repository.Edit(entity);
            return (await this.unitOfWork.Commit()) > 0;
        }

        /// <inheritdoc />
        public virtual async Task<bool> Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (await this.repository.Delete(entity) != null)
            {
                return await this.unitOfWork.Commit() > 0;
            }

            return true;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await this.repository.GetAll();
        }
    }
}
