// <copyright file="IBuildRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a repository for build aggregates.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IBuildRepository : IRepository<Build, BuildIdentifier>
    {
    }
}
