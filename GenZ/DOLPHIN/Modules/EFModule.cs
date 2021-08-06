// <copyright file="EFModule.cs" company="VSEC">
// Copyright (c) VSEC. All rights reserved.
// </copyright>

using Autofac;
using DOLPHIN.Model;
using DOLPHIN.Repository.Common;

namespace DOLPHIN.Modules
{
    /// <summary>
    /// Register autofac.
    /// </summary>
    public class EfModule : Module
    {
        /// <inheritdoc />
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ApplicationDBContext)).As(typeof(IDbContext)).InstancePerLifetimeScope();
            //builder.RegisterType(typeof(UnitOfWorkBase)).As(typeof(IUnitOfWork)).InstancePerLifetimeScope();
        }
    }
}
