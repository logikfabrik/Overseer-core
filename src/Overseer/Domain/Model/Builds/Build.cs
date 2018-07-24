// <copyright file="Build.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// A CI/CD build.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Build : IAggregateRoot<BuildIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Build" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="versionNumber">The version number.</param>
        /// <param name="branch">The branch.</param>
        /// <param name="startTime">The date and time the build was started.</param>
        /// <param name="finishTime">The date and time the build was finished.</param>
        /// <param name="status">The status.</param>
        /// <param name="requestedBy">Whoever requested the build.</param>
        /// <param name="webUrl">The CI/CD web URL for build details in the browser.</param>
        /// <param name="changes">The changes made since the last build.</param>
        private Build(BuildIdentifier id, string versionNumber, Branch branch, DateTime? startTime, DateTime? finishTime, BuildStatus status, User requestedBy, Uri webUrl, IEnumerable<Change> changes)
        {
            EnsureArg.IsNotNull(id);
            EnsureArg.IsNotNullOrEmpty(versionNumber);
            EnsureArg.IsNotNull(branch);
            EnsureArg.IsNotNull(requestedBy);

            var c = changes as Change[] ?? changes.ToArray();

            EnsureArg.IsNotNull(c);

            Id = id;
            VersionNumber = versionNumber;
            Branch = branch;
            StartTime = startTime;
            FinishTime = finishTime;
            Status = status;
            RequestedBy = requestedBy;
            WebUrl = webUrl;
            Changes = c;
        }

        /// <inheritdoc />
        public BuildIdentifier Id { get; }

        /// <summary>
        /// Gets the version number.
        /// </summary>
        /// <value>
        /// The version number.
        /// </value>
        public string VersionNumber { get; }

        /// <summary>
        /// Gets the branch.
        /// </summary>
        /// <value>
        /// The branch.
        /// </value>
        public Branch Branch { get; }

        /// <summary>
        /// Gets the date and time the build was started.
        /// </summary>
        /// <value>
        /// The date and time the build was started.
        /// </value>
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the build has started.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the build has started; otherwise, <c>false</c>.
        /// </value>
        public bool HasStarted => StartTime.HasValue;

        /// <summary>
        /// Gets the date and time the build was finished.
        /// </summary>
        /// <value>
        /// The date and time the build was finished.
        /// </value>
        public DateTime? FinishTime { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the build has finished.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the build has finished; otherwise, <c>false</c>.
        /// </value>
        public bool HasFinished => FinishTime.HasValue;

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public BuildStatus Status { get; private set; }

        /// <summary>
        /// Gets whoever requested the build.
        /// </summary>
        /// <value>
        /// Whoever requested the build.
        /// </value>
        public User RequestedBy { get; }

        /// <summary>
        /// Gets the CI/CD web URL for build details in the browser.
        /// </summary>
        /// <value>
        /// The CI/CD web URL for build details in the browser.
        /// </value>
        public Uri WebUrl { get; }

        /// <summary>
        /// Gets the changes made since the last build.
        /// </summary>
        /// <value>
        /// The changes made since the last build.
        /// </value>
        public IEnumerable<Change> Changes { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="Build" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="versionNumber">The version number.</param>
        /// <param name="branch">The branch.</param>
        /// <param name="startTime">The date and time the build was started.</param>
        /// <param name="finishTime">The date and time the build was finished.</param>
        /// <param name="status">The status.</param>
        /// <param name="requestedBy">Whoever requested the build.</param>
        /// <param name="webUrl">The CI/CD web URL for build details in the browser.</param>
        /// <param name="changes">The changes made since the last build.</param>
        /// <returns>A new instance of the <see cref="Build" /> class.</returns>
        public static Build Create(BuildIdentifier id, string versionNumber, Branch branch, DateTime? startTime, DateTime? finishTime, BuildStatus status, User requestedBy, Uri webUrl, IEnumerable<Change> changes)
        {
            var build = new Build(id, versionNumber, branch, startTime, finishTime, status, requestedBy, webUrl, changes);

            MessageBus.Publish(new BuildCreated(build));

            return build;
        }

        /// <summary>
        /// Gets for how long the build has been running, or for how long it ran.
        /// </summary>
        /// <param name="currentTime">The current date and time.</param>
        /// <returns>For how long the build has been running, or for how long it ran.</returns>
        public TimeSpan? GetRunTime(DateTime currentTime)
        {
            if (Status.IsStatusForBuildWhichHasRun())
            {
                return FinishTime - StartTime;
            }

            if (Status.IsStatusForBuildWhichIsRunning())
            {
                return currentTime - StartTime;
            }

            if (Status.IsStatusForBuildWhichWillRun())
            {
                return TimeSpan.Zero;
            }

            return null;
        }

        /// <summary>
        /// Starts the build.
        /// </summary>
        /// <param name="startTime">The date and time the build started.</param>
        public void Start(DateTime startTime)
        {
            if (HasStarted)
            {
                throw new InvalidOperationException("Build has already started.");
            }

            StartTime = startTime;
            Status = BuildStatus.InProgress;

            MessageBus.Publish(new BuildStarted(this));
        }

        /// <summary>
        /// Finishes the build.
        /// </summary>
        /// <param name="finishTime">The date and time the build finished.</param>
        /// <param name="status">The status.</param>
        public void Finish(DateTime finishTime, BuildStatus status)
        {
            if (HasFinished)
            {
                throw new InvalidOperationException("Build has already finished.");
            }

            FinishTime = finishTime;
            Status = status;

            MessageBus.Publish(new BuildFinished(this));
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

            return Id.Equals(((Build)obj).Id);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
