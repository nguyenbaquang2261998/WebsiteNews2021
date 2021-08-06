// <copyright file="ServiceModule.cs" company="VSEC">
// Copyright (c) VSEC. All rights reserved.
// </copyright>

using System.Reflection;
using Autofac;

namespace DOLPHIN.Modules
{
    /// <summary>
    /// Autofac for Service.
    /// </summary>
    public class ServiceModule : Autofac.Module
    {
        /// <inheritdoc />
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("DOLPHIN.Service"))
                      .Where(t => t.Name.EndsWith("Service"))
                      .PropertiesAutowired()
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope();
        }
    }
}
