// <copyright file="ProjectCreatedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Projects
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a project is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ProjectCreatedHandle : IHandle<ProjectCreated>
    {
        private readonly IProjectRepository _projectRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreatedHandle" /> class.
        /// </summary>
        /// <param name="projectRepository">The project repository.</param>
        public ProjectCreatedHandle(IProjectRepository projectRepository)
        {
            EnsureArg.IsNotNull(projectRepository);

            _projectRepository = projectRepository;
        }

        /// <inheritdoc />
        public void Handle(ProjectCreated message)
        {
            _projectRepository.Add(message.Entity);
        }
    }
}
