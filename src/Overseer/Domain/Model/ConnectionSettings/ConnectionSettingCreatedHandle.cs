// <copyright file="ConnectionSettingCreatedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a connection setting is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionSettingCreatedHandle : IHandle<ConnectionSettingCreated>
    {
        private readonly IConnectionSettingRepository _connectionSettingRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingCreatedHandle" /> class.
        /// </summary>
        /// <param name="connectionSettingRepository">The connection setting repository.</param>
        public ConnectionSettingCreatedHandle(IConnectionSettingRepository connectionSettingRepository)
        {
            EnsureArg.IsNotNull(connectionSettingRepository);

            _connectionSettingRepository = connectionSettingRepository;
        }

        /// <inheritdoc />
        public void Handle(ConnectionSettingCreated message)
        {
            _connectionSettingRepository.Add(message.Entity);

            MessageBus.Publish(new ConnectionSettingAdded(message.Entity));
        }
    }
}
