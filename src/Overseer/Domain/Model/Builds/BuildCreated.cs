// <copyright file="BuildCreated.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a build is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class BuildCreated : Event<Build, BuildIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCreated" /> class.
        /// </summary>
        /// <param name="build">The build.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public BuildCreated(Build build)
            : base(build)
        {
        }
    }
}
