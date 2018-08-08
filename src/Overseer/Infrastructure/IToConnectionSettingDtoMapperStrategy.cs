// <copyright file="IToConnectionSettingDtoMapperStrategy.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.ConnectionSettings;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Represents a strategy for creating a mapper to map a connection setting to a connection setting DTO.
    /// </summary>
    internal interface IToConnectionSettingDtoMapperStrategy
    {
        /// <summary>
        /// Creates a mapper to map the specified connection setting to a connection setting DTO.
        /// </summary>
        /// <param name="connectionSetting">The connection setting to map.</param>
        /// <returns>A mapper.</returns>
        ToConnectionSettingDtoMapper Create(ConnectionSetting connectionSetting);
    }
}
