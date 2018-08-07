// <copyright file="Module.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.TravisCI
{
    using Framework;
    using Ninject.Extensions.Factory;
    using Ninject.Modules;
    using ViewModels;

    /// <summary>
    /// Module that defines TravisCI specific bindings.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Module : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            Bind<IConductorMessageFactory<CreateConnectionSettingViewModel>>().ToFactory();
            Bind<Common.ViewModels.ISelectServiceViewModel>().To<SelectServiceViewModel>();
        }
    }
}
