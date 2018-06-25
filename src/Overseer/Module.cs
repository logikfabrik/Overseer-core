// <copyright file="Module.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer
{
    using Domain.Model.Builds;
    using Domain.Model.Connections;
    using Domain.Model.ConnectionSettings;
    using Domain.Model.Projects;
    using Domain.Model.Services;
    using Framework.IO;
    using Framework.Xml.Serialization;
    using Infrastructure;
    using Ninject.Modules;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Module that defines bindings.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Module : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            Bind<IFileSystem>().To<FileSystem>();

            Bind<XmlSerializer<ConnectionSettingDto>>().ToProvider<ConnectionSettingDtoXmlSerializerProvider>();

            Bind<IBuildRepository>().To<BuildRepository>().InSingletonScope();
            Bind<IConnectionRepository>().To<ConnectionRepository>().InSingletonScope();
            Bind<IConnectionSettingRepository>().To<ConnectionSettingRepository>().InSingletonScope();
            Bind<IProjectRepository>().To<ProjectRepository>().InSingletonScope();
            Bind<IServiceRepository>().To<ServiceRepository>().InSingletonScope();
        }
    }
}
