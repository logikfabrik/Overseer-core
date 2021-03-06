﻿// <copyright file="ConnectionRemoved.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a connection is removed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionRemoved : Event<Connection, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionRemoved" /> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionRemoved(Connection connection)
            : base(connection)
        {
        }
    }
}
