// <copyright file="CreateConnectionHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for creating a connection.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class CreateConnectionHandle : IHandle<CreateConnection>
    {
        /// <inheritdoc />
        public void Handle(CreateConnection message)
        {
            Connection.Create(message.ConnectionSettingId);
        }
    }
}
