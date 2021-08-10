namespace DOLPHIN.Repository.UnitOfWorks
{
    using DOLPHIN.Model;
    using DOLPHIN.Repository.Common;
    using DOLPHIN.Repository.Interfaces;
    using DOLPHIN.Repository.Repositories;
    using DOLPHIN.Repository.UnitOfWorks.Interfaces;

    /// <summary>
    /// NewsUnitOfWork.
    /// </summary>
    public class NewsUnitOfWork : UnitOfWorkBase, INewsUnitOfWork
    {
        private INewsRepository newsRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsUnitOfWork"/> class.
        /// </summary>
        /// <param name="dbcontext">.</param>
        public NewsUnitOfWork(IDbContext dbcontext)
            : base(dbcontext)
        {
        }

        /// <inheritdoc/>
        public INewsRepository NewsRepository => this.newsRepository ?? (this.newsRepository = new NewsRepository(this.dbContext));
    }
}
