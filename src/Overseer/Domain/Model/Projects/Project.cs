// <copyright file="Project.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Projects
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a CI/CD project.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Project : IAggregateRoot<ProjectIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The CI/CD project name.</param>
        private Project(ProjectIdentifier id, string name)
        {
            EnsureArg.IsNotNull(id);

            Id = id;
            Name = name ?? string.Empty;
        }

        /// <inheritdoc />
        public ProjectIdentifier Id { get; }

        /// <summary>
        /// Gets the CI/CD project name.
        /// </summary>
        /// <value>
        /// The CI/CD project name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The CI/CD project name.</param>
        /// <returns>A new instance of the <see cref="Project" /> class.</returns>
        public static Project Create(ProjectIdentifier id, string name)
        {
            var project = new Project(id, name);

            MessageBus.Publish(new ProjectCreated(project));

            return project;
        }

        /// <summary>
        /// Renames the project.
        /// </summary>
        /// <param name="name">The CI/CD project name to change to.</param>
        public void Rename(string name)
        {
            Name = name ?? string.Empty;

            MessageBus.Publish(new ProjectRenamed(this));
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

            return Id.Equals(((Project)obj).Id);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
