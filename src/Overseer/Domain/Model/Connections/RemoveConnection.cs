// <copyright file="RemoveConnection.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Command to be published to remove a connection.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class RemoveConnection : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveConnection" /> class.
        /// </summary>
        /// <param name="connectionSettingId">The connection setting identifier.</param>
        public RemoveConnection(Guid connectionSettingId)
        {
            EnsureArg.IsNotEmpty(connectionSettingId);

            ConnectionSettingId = connectionSettingId;
        }

        /// <summary>
        /// Gets the connection setting identifier.
        /// </summary>
        /// <value>
        /// The connection setting identifier.
        /// </value>
        public Guid ConnectionSettingId { get; }
    }
}
