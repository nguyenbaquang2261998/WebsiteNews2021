using Autofac;
using DOLPHIN.Repository.UnitOfWorks;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.WebApi.Modules
{
    public class UnitOfWorkModule : Module
    {
        /// <inheritdoc />
        protected override void Load(ContainerBuilder builder)
        {
        }
    }
}
