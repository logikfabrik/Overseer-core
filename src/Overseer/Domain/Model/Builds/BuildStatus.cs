// <copyright file="BuildStatus.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    /// <summary>
    /// Represents a build status.
    /// </summary>
    public enum BuildStatus
    {
        /// <summary>
        /// The build failed.
        /// </summary>
        Failed = 0,

        /// <summary>
        /// The build succeeded.
        /// </summary>
        Succeeded = 1,

        /// <summary>
        /// The build is in progress.
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// The build was stopped.
        /// </summary>
        Stopped = 3,

        /// <summary>
        /// The build is queued.
        /// </summary>
        Queued = 4
    }
}