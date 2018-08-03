﻿// <copyright file="IServiceProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Overseer.Domain.Model.Builds;
    using Overseer.Domain.Model.Projects;

    public interface IServiceProvider
    {
        Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken cancellationToken);

        Task<IEnumerable<Build>> GetBuildsAsync(string projectId, CancellationToken cancellationToken);
    }
}
