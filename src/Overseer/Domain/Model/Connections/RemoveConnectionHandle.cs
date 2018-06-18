// <copyright file="RemoveConnectionHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for removing a connection.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class RemoveConnectionHandle : IHandle<RemoveConnection>
    {
        private readonly IConnectionRepository _connectionRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveConnectionHandle" /> class.
        /// </summary>
        /// <param name="connectionRepository">The connection repository.</param>
        public RemoveConnectionHandle(IConnectionRepository connectionRepository)
        {
            EnsureArg.IsNotNull(connectionRepository);

            _connectionRepository = connectionRepository;
        }

        /// <inheritdoc />
        public void Handle(RemoveConnection message)
        {
            var connection = _connectionRepository.GetAll().SingleOrDefault(c => c.ConnectionSettingId == message.ConnectionSettingId);

            if (connection == null)
            {
                return;
            }

            _connectionRepository.Remove(connection.Id);

            MessageBus.Publish(new ConnectionRemoved(connection));
        }
    }
}
