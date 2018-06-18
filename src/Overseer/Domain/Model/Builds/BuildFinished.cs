// <copyright file="BuildFinished.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a build is finished.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class BuildFinished : Event<Build, BuildIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFinished" /> class.
        /// </summary>
        /// <param name="build">The build.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public BuildFinished(Build build)
            : base(build)
        {
        }
    }
}
