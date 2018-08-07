// <copyright file="Module.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor
{
    using Domain;
    using Infrastructure;
    using Ninject.Modules;
    using Overseer.Common.Domain;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Module that defines AppVeyor specific bindings.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Module : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            Bind<IBootstrapper>().To<Bootstrapper>();
            Bind<IConnectionSettingDtoFactory>().To<ConnectionSettingDtoFactory>();
            Bind<IConnectionSettingFactory>().To<ConnectionSettingFactory>();
            Bind<IServiceProvider>().To<ServiceProvider>();
        }
    }
}
