// <copyright file="Module.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor
{
    using Ninject.Modules;
    using ViewModels;

    /// <summary>
    /// Module that defines AppVeyor specific bindings.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Module : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            Bind<Common.ViewModels.ServiceViewModel>().To<ServiceViewModel>();
        }
    }
}
