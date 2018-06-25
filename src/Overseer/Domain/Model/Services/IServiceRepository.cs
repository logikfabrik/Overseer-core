// <copyright file="IServiceRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Services
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a repository for CI/CD service aggregates.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IServiceRepository : IRepository<Service, Guid>
    {
    }
}
