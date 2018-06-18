// <copyright file="IConnectionService.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a service for connection aggregates.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IConnectionService : IService
    {
        /// <summary>
        /// Connects the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        void Connect(Connection connection);

        /// <summary>
        /// Disconnects the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        void Disconnect(Connection connection);

        /// <summary>
        /// Refreshes the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        void Refresh(Connection connection);
    }
}
