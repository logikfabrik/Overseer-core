// <copyright file="IProjectRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Projects
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a repository for project aggregates.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IProjectRepository : IRepository<Project, ProjectIdentifier>
    {
    }
}
