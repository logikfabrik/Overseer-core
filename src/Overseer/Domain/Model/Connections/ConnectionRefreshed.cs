// <copyright file="ConnectionRefreshed.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a connection is refreshed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionRefreshed : Event<Connection, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionRefreshed" /> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionRefreshed(Connection connection)
            : base(connection)
        {
        }
    }
}
