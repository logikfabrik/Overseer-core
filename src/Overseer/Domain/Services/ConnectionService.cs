// <copyright file="ConnectionService.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Services
{
    using System;
    using EnsureThat;
    using Infrastructure;
    using Model.Connections;
    using Model.ConnectionSettings;

    internal sealed class ConnectionService : IConnectionService
    {
        private readonly IConnectionSettingRepository _connectionSettingRepository;
        private readonly IServiceProviderFactory _serviceProviderFactory;

        public ConnectionService(IConnectionSettingRepository connectionSettingRepository, IServiceProviderFactory serviceProviderFactory)
        {
            EnsureArg.IsNotNull(connectionSettingRepository);
            EnsureArg.IsNotNull(serviceProviderFactory);

            _connectionSettingRepository = connectionSettingRepository;
            _serviceProviderFactory = serviceProviderFactory;
        }

        public void Connect(Connection connection)
        {
            EnsureArg.IsNotNull(connection);

            var connectionSetting = _connectionSettingRepository.Get(connection.ConnectionSettingId);

            connection.ChangeStatus(ConnectionStatus.Failed);

            var serviceProvider = _serviceProviderFactory.Create(connectionSetting);

            throw new NotImplementedException();
        }

        public void Disconnect(Connection connection)
        {
            throw new NotImplementedException();
        }

        public void Refresh(Connection connection)
        {
            throw new NotImplementedException();
        }
    }
}
