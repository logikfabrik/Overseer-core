// <copyright file="ConnectionService.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Services
{
    using System;
    using EnsureThat;
    using Model.Connections;
    using Model.ConnectionSettings;

    internal sealed class ConnectionService : IConnectionService
    {
        private readonly IConnectionSettingRepository _connectionSettingRepository;

        public ConnectionService(IConnectionSettingRepository connectionSettingRepository)
        {
            EnsureArg.IsNotNull(connectionSettingRepository);

            _connectionSettingRepository = connectionSettingRepository;
        }

        public void Connect(Connection connection)
        {
            EnsureArg.IsNotNull(connection);

            var connectionSetting = _connectionSettingRepository.Get(connection.ConnectionSettingId);

            connection.ChangeStatus(ConnectionStatus.Failed);

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
