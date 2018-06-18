// <copyright file="ProjectRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.Projects;
    using Overseer.Common.Infrastructure;

    /// <inheritdoc cref="IProjectRepository" />
    internal sealed class ProjectRepository : MemoryRepositoy<Project, ProjectIdentifier>, IProjectRepository
    {
    }
}
