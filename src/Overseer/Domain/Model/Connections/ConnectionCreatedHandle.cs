// <copyright file="ConnectionCreatedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a connection is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionCreatedHandle : IHandle<ConnectionCreated>
    {
        private readonly IConnectionRepository _connectionRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionCreatedHandle" /> class.
        /// </summary>
        /// <param name="connectionRepository">The connection repository.</param>
        public ConnectionCreatedHandle(IConnectionRepository connectionRepository)
        {
            EnsureArg.IsNotNull(connectionRepository);

            _connectionRepository = connectionRepository;
        }

        /// <inheritdoc />
        public void Handle(ConnectionCreated message)
        {
            _connectionRepository.Add(message.Entity);

            MessageBus.Publish(new ConnectionAdded(message.Entity));
        }
    }
}
