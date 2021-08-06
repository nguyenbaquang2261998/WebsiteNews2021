// <copyright file="MappingModule.cs" company="VSEC">
// Copyright (c) VSEC. All rights reserved.
// </copyright>

using Autofac;
using AutoMapper;

namespace DOLPHIN.Modules
{
    /// <inheritdoc />
    public class MappingModule : Module
    {
        /// <inheritdoc />
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(Mapper)).As(typeof(IMapper)).InstancePerLifetimeScope().PropertiesAutowired();
        }
    }
}
