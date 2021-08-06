using DOLPHIN.Repository.Common;

namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
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
