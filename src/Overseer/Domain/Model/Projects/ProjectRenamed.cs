// <copyright file="ProjectRenamed.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Projects
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a project is renamed.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ProjectRenamed : Event<Project, ProjectIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRenamed" /> class.
        /// </summary>
        /// <param name="project">The project.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ProjectRenamed(Project project)
            : base(project)
        {
        }
    }
}
