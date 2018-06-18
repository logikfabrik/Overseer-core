// <copyright file="BuildRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.Builds;
    using Overseer.Common.Infrastructure;

    /// <inheritdoc cref="IBuildRepository" />
    internal sealed class BuildRepository : MemoryRepositoy<Build, BuildIdentifier>, IBuildRepository
    {
    }
}
