// <copyright file="ConnectionStatusChanged.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when the status of a connection is changed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionStatusChanged : Event<Connection, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionStatusChanged" /> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionStatusChanged(Connection connection)
            : base(connection)
        {
        }
    }
}
