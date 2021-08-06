using DOLPHIN.Model.Common.Interfaces;

namespace DOLPHIN.Model.Common
{
    public abstract class Entity<T> : IEntity<T>
    {
        /// <inheritdoc/>
        public T Id { get; set; }
    }
}
