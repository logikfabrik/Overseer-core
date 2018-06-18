// <copyright file="Module.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

using Overseer.Common.Infrastructure;
using Overseer.Framework.Xml.Serialization;

namespace Overseer
{
    using Domain.Model.Builds;
    using Domain.Model.Connections;
    using Domain.Model.ConnectionSettings;
    using Domain.Model.Projects;
    using Infrastructure;
    using Ninject.Modules;

    /// <summary>
    /// Module that defines domain specific bindings.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Module : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            Bind<XmlSerializer<ConnectionSettingDto>>().ToProvider<ConnectionSettingDtoXmlSerializerProvider>();

            Bind<IBuildRepository>().To<BuildRepository>().InSingletonScope();
            Bind<IConnectionRepository>().To<ConnectionRepository>().InSingletonScope();
            Bind<IConnectionSettingRepository>().To<ConnectionSettingRepository>().InSingletonScope();
            Bind<IProjectRepository>().To<ProjectRepository>().InSingletonScope();
        }
    }
}
