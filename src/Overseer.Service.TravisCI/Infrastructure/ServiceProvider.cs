// <copyright file="ServiceProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.TravisCI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Domain.Model.Builds;
    using Overseer.Domain.Model.Projects;

    /// <summary>
    /// Service provider for querying the TravisCI CI/CD service for projects and builds.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ServiceProvider : Common.Infrastructure.IServiceProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvider" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        public ServiceProvider(ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);
        }

        /// <inheritdoc />
        public Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<IEnumerable<Build>> GetBuildsAsync(string projectId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
