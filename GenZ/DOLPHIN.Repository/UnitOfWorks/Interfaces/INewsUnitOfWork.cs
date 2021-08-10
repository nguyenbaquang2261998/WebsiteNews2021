namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;

    /// <summary>
    /// Interface NewsUnitOfWork.
    /// </summary>
    public interface INewsUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets newsRepository.
        /// </summary>
        INewsRepository NewsRepository { get; }
    }
}
