using System;
using System.Threading.Tasks;

namespace DOLPHIN.Repository.Common
{
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
