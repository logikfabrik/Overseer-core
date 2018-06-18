// <copyright file="ConnectionAddedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a connection is added.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionAddedHandle : IHandle<ConnectionAdded>
    {
        private readonly IConnectionService _connectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionAddedHandle" /> class.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public ConnectionAddedHandle(IConnectionService connectionService)
        {
            EnsureArg.IsNotNull(connectionService);

            _connectionService = connectionService;
        }

        /// <inheritdoc />
        public void Handle(ConnectionAdded message)
        {
            _connectionService.Connect(message.Entity);
        }
    }
}
