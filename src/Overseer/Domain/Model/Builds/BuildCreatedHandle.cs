// <copyright file="BuildCreatedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a build is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class BuildCreatedHandle : IHandle<BuildCreated>
    {
        private readonly IBuildRepository _buildRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCreatedHandle" /> class.
        /// </summary>
        /// <param name="buildRepository">The build repository.</param>
        public BuildCreatedHandle(IBuildRepository buildRepository)
        {
            EnsureArg.IsNotNull(buildRepository);

            _buildRepository = buildRepository;
        }

        /// <inheritdoc />
        public void Handle(BuildCreated message)
        {
            _buildRepository.Add(message.Entity);
        }
    }
}
