// <copyright file="ConnectionStatus.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    /// <summary>
    /// Connection status.
    /// </summary>
    public enum ConnectionStatus
    {
        /// <summary>
        /// The connection failed.
        /// </summary>
        Failed = 0,

        /// <summary>
        /// The connection succeeded.
        /// </summary>
        Succeeded = 1,

        /// <summary>
        /// The connection is pending.
        /// </summary>
        Pending = 2
    }
}
