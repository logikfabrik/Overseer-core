// <copyright file="ConnectionRemovedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a connection is removed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionRemovedHandle : IHandle<ConnectionRemoved>
    {
        private readonly IConnectionService _connectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionRemovedHandle" /> class.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public ConnectionRemovedHandle(IConnectionService connectionService)
        {
            EnsureArg.IsNotNull(connectionService);

            _connectionService = connectionService;
        }

        /// <inheritdoc />
        public void Handle(ConnectionRemoved message)
        {
            _connectionService.Disconnect(message.Entity);
        }
    }
}
