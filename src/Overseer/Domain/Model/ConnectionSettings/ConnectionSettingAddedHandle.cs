// <copyright file="ConnectionSettingAddedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using Connections;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a connection setting is added.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionSettingAddedHandle : IHandle<ConnectionSettingAdded>
    {
        /// <inheritdoc />
        public void Handle(ConnectionSettingAdded message)
        {
            MessageBus.Publish(new CreateConnection(message.Entity.Id));
        }
    }
}
