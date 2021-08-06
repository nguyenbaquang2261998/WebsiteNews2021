using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.Model.Common.Interfaces
{
    public interface IEntity<T>
    {
        /// <summary>
        /// Gets or sets <see cref="Id"/>.
        /// </summary>
        T Id { get; set; }
    }
}
