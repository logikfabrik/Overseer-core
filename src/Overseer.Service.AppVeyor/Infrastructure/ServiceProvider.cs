// <copyright file="ServiceProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Overseer.Domain.Model.Builds;
    using Overseer.Domain.Model.Projects;

    /// <summary>
    /// Service provider for querying the AppVeyor CI/CD service for projects and builds.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ServiceProvider : Common.Infrastructure.ServiceProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvider" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ServiceProvider(Overseer.Domain.Model.ConnectionSettings.ConnectionSetting connectionSetting)
            : base(connectionSetting)
        {
        }

        /// <inheritdoc />
        public override Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Task<IEnumerable<Build>> GetBuildsAsync(string projectId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
