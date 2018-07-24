// <copyright file="BuildIdentifier.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// An identifier for a CI/CD build.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class BuildIdentifier : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildIdentifier" /> class.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="projectId">The CI/CD project identifier.</param>
        /// <param name="buildId">The CI/CD build identifier.</param>
        private BuildIdentifier(string connectionId, string projectId, string buildId)
        {
            EnsureArg.IsNotNullOrEmpty(connectionId);
            EnsureArg.IsNotNullOrEmpty(projectId);
            EnsureArg.IsNotNullOrEmpty(buildId);

            ConnectionId = connectionId;
            ProjectId = projectId;
            BuildId = buildId;
        }

        /// <summary>
        /// Gets the connection identifier.
        /// </summary>
        /// <value>
        /// The connection identifier.
        /// </value>
        public string ConnectionId { get; }

        /// <summary>
        /// Gets the CI/CD project identifier.
        /// </summary>
        /// <value>
        /// The CI/CD project identifier.
        /// </value>
        public string ProjectId { get; }

        /// <summary>
        /// Gets the CI/CD build identifier.
        /// </summary>
        /// <value>
        /// The CI/CD build identifier.
        /// </value>
        public string BuildId { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="BuildIdentifier" /> class.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="projectId">The CI/CD project identifier.</param>
        /// <param name="buildId">The CI/CD build identifier.</param>
        /// <returns>A new instance of the <see cref="BuildIdentifier" /> class.</returns>
        public static BuildIdentifier Create(string connectionId, string projectId, string buildId)
        {
            return new BuildIdentifier(connectionId, projectId, buildId);
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

            var o = (BuildIdentifier)obj;

            return new[]
            {
                ConnectionId,
                ProjectId,
                BuildId
            }.SequenceEqual(new[]
            {
                o.ConnectionId,
                o.ProjectId,
                o.BuildId
            });
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Generate(new[] { ConnectionId, ProjectId, BuildId });
        }
    }
}
