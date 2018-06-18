// <copyright file="IConnectionRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Connections
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a repository for connection aggregates.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IConnectionRepository : IRepository<Connection, Guid>
    {
    }
}
