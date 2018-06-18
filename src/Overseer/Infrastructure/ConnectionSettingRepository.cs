// <copyright file="ConnectionSettingRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using Domain.Model.ConnectionSettings;
    using Overseer.Common.Infrastructure;

    /// <inheritdoc cref="IConnectionSettingRepository" />
    internal sealed class ConnectionSettingRepository : MemoryRepositoy<ConnectionSetting, Guid>, IConnectionSettingRepository
    {
    }
}
