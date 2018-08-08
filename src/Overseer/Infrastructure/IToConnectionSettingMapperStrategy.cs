﻿// <copyright file="IToConnectionSettingMapperStrategy.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Represents a strategy for creating a mapper to map a connection setting DTO to a connection setting.
    /// </summary>
    internal interface IToConnectionSettingMapperStrategy
    {
        /// <summary>
        /// Creates a mapper to map the specified connection setting DTO to a connection setting.
        /// </summary>
        /// <param name="connectionSettingDto">The connection setting to map.</param>
        /// <returns>A mapper.</returns>
        ToConnectionSettingMapper Create(ConnectionSettingDto connectionSettingDto);
    }
}
