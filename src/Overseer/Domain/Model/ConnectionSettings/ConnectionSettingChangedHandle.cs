// <copyright file="ConnectionSettingChangedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using Connections;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a connection setting is changed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionSettingChangedHandle : IHandle<ConnectionSettingChanged>
    {
        /// <inheritdoc />
        public void Handle(ConnectionSettingChanged message)
        {
            MessageBus.Publish(new RefreshConnection(message.Entity.Id));
        }
    }
}
