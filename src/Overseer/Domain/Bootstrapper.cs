// <copyright file="Bootstrapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain
{
    using EnsureThat;
    using Model.Builds;
    using Model.Connections;
    using Model.ConnectionSettings;
    using Model.Projects;
    using Overseer.Common.Domain;
    using Overseer.Common.Domain.Model;

    /// <inheritdoc />
    internal sealed class Bootstrapper : IBootstrapper
    {
        private readonly IHandleFactory<BuildCreatedHandle, BuildCreated> _buildCreatedHandleFactory;
        private readonly IHandleFactory<ConnectionAddedHandle, ConnectionAdded> _connectionAddedHandleFactory;
        private readonly IHandleFactory<ConnectionCreatedHandle, ConnectionCreated> _connectionCreatedHandleFactory;
        private readonly IHandleFactory<ConnectionRemovedHandle, ConnectionRemoved> _connectionRemovedHandleFactory;
        private readonly IHandleFactory<CreateConnectionHandle, CreateConnection> _createConnectionHandleFactory;
        private readonly IHandleFactory<RefreshConnectionHandle, RefreshConnection> _refreshConnectionHandleFactory;
        private readonly IHandleFactory<RemoveConnectionHandle, RemoveConnection> _removeConnectionHandleFactory;
        private readonly IHandleFactory<ConnectionSettingAddedHandle, ConnectionSettingAdded> _connectionSettingAddedHandleFactory;
        private readonly IHandleFactory<ConnectionSettingChangedHandle, ConnectionSettingChanged> _connectionSettingChangedHandleFactory;
        private readonly IHandleFactory<ConnectionSettingCreatedHandle, ConnectionSettingCreated> _connectionSettingCreatedHandleFactory;
        private readonly IHandleFactory<ProjectCreatedHandle, ProjectCreated> _projectCreatedHandleFactory;

        public Bootstrapper(
            IHandleFactory<BuildCreatedHandle, BuildCreated> buildCreatedHandleFactory,
            IHandleFactory<ConnectionAddedHandle, ConnectionAdded> connectionAddedHandleFactory,
            IHandleFactory<ConnectionCreatedHandle, ConnectionCreated> connectionCreatedHandleFactory,
            IHandleFactory<ConnectionRemovedHandle, ConnectionRemoved> connectionRemovedHandleFactory,
            IHandleFactory<CreateConnectionHandle, CreateConnection> createConnectionHandleFactory,
            IHandleFactory<RefreshConnectionHandle, RefreshConnection> refreshConnectionHandleFactory,
            IHandleFactory<RemoveConnectionHandle, RemoveConnection> removeConnectionHandleFactory,
            IHandleFactory<ConnectionSettingAddedHandle, ConnectionSettingAdded> connectionSettingAddedHandleFactory,
            IHandleFactory<ConnectionSettingChangedHandle, ConnectionSettingChanged> connectionSettingChangedHandleFactory,
            IHandleFactory<ConnectionSettingCreatedHandle, ConnectionSettingCreated> connectionSettingCreatedHandleFactory,
            IHandleFactory<ProjectCreatedHandle, ProjectCreated> projectCreatedHandleFactory)
        {
            EnsureArg.IsNotNull(buildCreatedHandleFactory);
            EnsureArg.IsNotNull(connectionAddedHandleFactory);
            EnsureArg.IsNotNull(connectionCreatedHandleFactory);
            EnsureArg.IsNotNull(connectionRemovedHandleFactory);
            EnsureArg.IsNotNull(createConnectionHandleFactory);
            EnsureArg.IsNotNull(refreshConnectionHandleFactory);
            EnsureArg.IsNotNull(removeConnectionHandleFactory);
            EnsureArg.IsNotNull(connectionSettingAddedHandleFactory);
            EnsureArg.IsNotNull(connectionSettingChangedHandleFactory);
            EnsureArg.IsNotNull(connectionSettingCreatedHandleFactory);
            EnsureArg.IsNotNull(projectCreatedHandleFactory);

            _buildCreatedHandleFactory = buildCreatedHandleFactory;
            _connectionAddedHandleFactory = connectionAddedHandleFactory;
            _connectionCreatedHandleFactory = connectionCreatedHandleFactory;
            _connectionRemovedHandleFactory = connectionRemovedHandleFactory;
            _createConnectionHandleFactory = createConnectionHandleFactory;
            _refreshConnectionHandleFactory = refreshConnectionHandleFactory;
            _removeConnectionHandleFactory = removeConnectionHandleFactory;
            _connectionSettingAddedHandleFactory = connectionSettingAddedHandleFactory;
            _connectionSettingChangedHandleFactory = connectionSettingChangedHandleFactory;
            _connectionSettingCreatedHandleFactory = connectionSettingCreatedHandleFactory;
            _projectCreatedHandleFactory = projectCreatedHandleFactory;
        }

        /// <inheritdoc />
        public void Run()
        {
            MessageBus.Subscribe(_buildCreatedHandleFactory.Create());
            MessageBus.Subscribe(_connectionAddedHandleFactory.Create());
            MessageBus.Subscribe(_connectionCreatedHandleFactory.Create());
            MessageBus.Subscribe(_connectionRemovedHandleFactory.Create());
            MessageBus.Subscribe(_createConnectionHandleFactory.Create());
            MessageBus.Subscribe(_refreshConnectionHandleFactory.Create());
            MessageBus.Subscribe(_removeConnectionHandleFactory.Create());
            MessageBus.Subscribe(_connectionSettingAddedHandleFactory.Create());
            MessageBus.Subscribe(_connectionSettingChangedHandleFactory.Create());
            MessageBus.Subscribe(_connectionSettingCreatedHandleFactory.Create());
            MessageBus.Subscribe(_projectCreatedHandleFactory.Create());
        }
    }
}