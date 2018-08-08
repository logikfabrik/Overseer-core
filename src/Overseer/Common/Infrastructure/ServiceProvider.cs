// <copyright file="ServiceProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using EnsureThat;
    using Overseer.Domain.Model.Builds;
    using Overseer.Domain.Model.ConnectionSettings;
    using Overseer.Domain.Model.Projects;

    /// <summary>
    /// Base class for service provider for querying a CI/CD service for projects and builds.
    /// </summary>
    public abstract class ServiceProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvider" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        protected ServiceProvider(ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);

            ConnectionSetting = connectionSetting;
        }

        /// <summary>
        /// Gets the connection setting.
        /// </summary>
        /// <value>
        /// The connection setting.
        /// </value>
        protected ConnectionSetting ConnectionSetting { get; }

        public abstract Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken cancellationToken);

        public abstract Task<IEnumerable<Build>> GetBuildsAsync(string projectId, CancellationToken cancellationToken);
    }
}
