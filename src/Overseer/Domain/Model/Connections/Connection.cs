﻿// <copyright file="Connection.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// A connection to a CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Connection : IAggregateRoot<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="connectionSettingId">The connection setting identifier.</param>
        private Connection(Guid id, Guid connectionSettingId)
        {
            EnsureArg.IsNotEmpty(id);
            EnsureArg.IsNotEmpty(connectionSettingId);

            Id = id;
            ConnectionSettingId = connectionSettingId;
            Status = ConnectionStatus.Pending;
        }

        /// <inheritdoc />
        public Guid Id { get; }

        /// <summary>
        /// Gets the connection setting identifier.
        /// </summary>
        /// <value>
        /// The connection setting identifier.
        /// </value>
        public Guid ConnectionSettingId { get; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public ConnectionStatus Status { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="connectionSettingId">The connection setting identifier.</param>
        /// <returns>A new instance of the <see cref="Connection" /> class.</returns>
        public static Connection Create(Guid connectionSettingId)
        {
            var connection = new Connection(Guid.NewGuid(), connectionSettingId);

            MessageBus.Publish(new ConnectionCreated(connection));

            return connection;
        }

        public void ChangeStatus(ConnectionStatus status)
        {
            Status = status;

            MessageBus.Publish(new ConnectionStatusChanged(this));
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Id.Equals(((Connection)obj).Id);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
