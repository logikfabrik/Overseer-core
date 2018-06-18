// <copyright file="RefreshConnectionHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for refreshing a connection.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class RefreshConnectionHandle : IHandle<RefreshConnection>
    {
        private readonly IConnectionService _connectionService;
        private readonly IConnectionRepository _connectionRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshConnectionHandle" /> class.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        /// <param name="connectionRepository">The connection repository.</param>
        public RefreshConnectionHandle(IConnectionService connectionService, IConnectionRepository connectionRepository)
        {
            EnsureArg.IsNotNull(connectionService);
            EnsureArg.IsNotNull(connectionRepository);

            _connectionService = connectionService;
            _connectionRepository = connectionRepository;
        }

        /// <inheritdoc />
        public void Handle(RefreshConnection message)
        {
            var connection = _connectionRepository.GetAll().SingleOrDefault(c => c.ConnectionSettingId == message.ConnectionSettingId);

            if (connection == null)
            {
                return;
            }

            _connectionService.Refresh(connection);

            MessageBus.Publish(new ConnectionRefreshed(connection));
        }
    }
}
