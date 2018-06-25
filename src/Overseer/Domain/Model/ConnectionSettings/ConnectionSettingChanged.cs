// <copyright file="ConnectionSettingChanged.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a connection setting is changed.
    /// </summary>
    /// <remarks>This class has intentionally been made public.</remarks>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConnectionSettingChanged : Event<ConnectionSetting, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingChanged" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionSettingChanged(ConnectionSetting connectionSetting)
            : base(connectionSetting)
        {
        }
    }
}
