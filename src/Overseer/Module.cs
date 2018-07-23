// <copyright file="Module.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer
{
    using Domain;
    using Domain.Model.Builds;
    using Domain.Model.Connections;
    using Domain.Model.ConnectionSettings;
    using Domain.Model.Projects;
    using Domain.Model.Services;
    using Domain.Services;
    using Framework.IO;
    using Framework.Xml.Serialization;
    using Infrastructure;
    using Ninject.Extensions.Factory;
    using Ninject.Modules;
    using Overseer.Common.Domain;
    using Overseer.Common.Domain.Model;
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
            // Bind framework classes.
            Bind<IFileSystem>().To<FileSystem>();

            Bind<XmlSerializer<ConnectionSettingDto>>().ToProvider<ConnectionSettingDtoXmlSerializerProvider>();

            // Bind domain model repositories.
            Bind<IBuildRepository>().To<BuildRepository>().InSingletonScope();
            Bind<IConnectionRepository>().To<ConnectionRepository>().InSingletonScope();
            Bind<IConnectionSettingRepository>().To<ConnectionSettingRepository>().InSingletonScope();
            Bind<IProjectRepository>().To<ProjectRepository>().InSingletonScope();
            Bind<IServiceRepository>().To<ServiceRepository>().InSingletonScope();

            // Bind factories for doman model handles and services.
            Bind<IHandleFactory<BuildCreatedHandle, BuildCreated>>().ToFactory();
            Bind<IHandleFactory<ConnectionAddedHandle, ConnectionAdded>>().ToFactory();
            Bind<IHandleFactory<ConnectionCreatedHandle, ConnectionCreated>>().ToFactory();
            Bind<IHandleFactory<ConnectionRemovedHandle, ConnectionRemoved>>().ToFactory();
            Bind<IHandleFactory<CreateConnectionHandle, CreateConnection>>().ToFactory();
            Bind<IHandleFactory<RefreshConnectionHandle, RefreshConnection>>().ToFactory();
            Bind<IHandleFactory<RemoveConnectionHandle, RemoveConnection>>().ToFactory();
            Bind<IHandleFactory<ConnectionSettingAddedHandle, ConnectionSettingAdded>>().ToFactory();
            Bind<IHandleFactory<ConnectionSettingChangedHandle, ConnectionSettingChanged>>().ToFactory();
            Bind<IHandleFactory<ConnectionSettingCreatedHandle, ConnectionSettingCreated>>().ToFactory();
            Bind<IHandleFactory<ProjectCreatedHandle, ProjectCreated>>().ToFactory();

            Bind<IConnectionService>().To<ConnectionService>();

            Bind<IBootstrapper>().To<Bootstrapper>();
        }
    }
}
