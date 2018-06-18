// <copyright file="ConnectionSettingRenamed.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a connection setting is renamed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionSettingRenamed : Event<ConnectionSetting, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingRenamed" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionSettingRenamed(ConnectionSetting connectionSetting)
            : base(connectionSetting)
        {
        }
    }
}
