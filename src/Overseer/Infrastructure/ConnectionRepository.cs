// <copyright file="ConnectionRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using Domain.Model.Connections;
    using Overseer.Common.Infrastructure;

    /// <inheritdoc cref="IConnectionRepository" />
    internal sealed class ConnectionRepository : MemoryRepositoy<Connection, Guid>, IConnectionRepository
    {
    }
}
