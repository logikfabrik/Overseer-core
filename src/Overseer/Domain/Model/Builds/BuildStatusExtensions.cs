// <copyright file="BuildStatusExtensions.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using System.Linq;

    public static class BuildStatusExtensions
    {
        /// <summary>
        /// Determines whether the specified status is for a build which has run.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns><c>true</c> if for a build which has run; otherwise, <c>false</c>.</returns>
        public static bool IsStatusForBuildWhichHasRun(this BuildStatus status)
        {
            return new[] { BuildStatus.Failed, BuildStatus.Succeeded, BuildStatus.Stopped }.Contains(status);
        }

        /// <summary>
        /// Determines whether the specified status is for a build which is running.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns><c>true</c> if for a build which is running; otherwise, <c>false</c>.</returns>
        public static bool IsStatusForBuildWhichIsRunning(this BuildStatus status)
        {
            return status == BuildStatus.InProgress;
        }

        /// <summary>
        /// Determines whether the specified status is for a build which will run.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns><c>true</c> if for a build which will run; otherwise, <c>false</c>.</returns>
        public static bool IsStatusForBuildWhichWillRun(this BuildStatus status)
        {
            return status == BuildStatus.Queued;
        }
    }
}
