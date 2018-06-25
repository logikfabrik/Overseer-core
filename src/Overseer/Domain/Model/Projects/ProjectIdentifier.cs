// <copyright file="ProjectIdentifier.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Projects
{
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents an identifier for a CI/CD project.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ProjectIdentifier : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectIdentifier" /> class.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="projectId">The CI/CD project identifier.</param>
        private ProjectIdentifier(string connectionId, string projectId)
        {
            EnsureArg.IsNotNullOrEmpty(connectionId);
            EnsureArg.IsNotNullOrEmpty(projectId);

            ConnectionId = connectionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Gets the connection identifier.
        /// </summary>
        /// <value>
        /// The connection identifier.
        /// </value>
        public string ConnectionId { get; }

        /// <summary>
        /// Gets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        public string ProjectId { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="ProjectIdentifier" /> class.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="projectId">The CI/CD project identifier.</param>
        /// <returns>A new instance of the <see cref="ProjectIdentifier" /> class.</returns>
        public static ProjectIdentifier Create(string connectionId, string projectId)
        {
            return new ProjectIdentifier(connectionId, projectId);
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

            var o = (ProjectIdentifier)obj;

            return new[]
            {
                ConnectionId,
                ProjectId
            }.SequenceEqual(new[]
            {
                o.ConnectionId,
                o.ProjectId
            });
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Generate(new[] { ConnectionId, ProjectId });
        }
    }
}
