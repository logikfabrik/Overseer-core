// <copyright file="IConnectionSettingRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a repository for connection setting aggregates.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IConnectionSettingRepository : IRepository<ConnectionSetting, Guid>
    {
    }
}
