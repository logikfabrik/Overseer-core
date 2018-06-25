// <copyright file="ConnectionSettingCreated.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a connection setting is created.
    /// </summary>
    /// <remarks>This class has intentionally been made public.</remarks>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConnectionSettingCreated : Event<ConnectionSetting, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingCreated" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionSettingCreated(ConnectionSetting connectionSetting)
            : base(connectionSetting)
        {
        }
    }
}