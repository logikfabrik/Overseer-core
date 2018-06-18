// <copyright file="IConnectionSettingDtoFactory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System;
    using Overseer.Domain.Model.ConnectionSettings;

    /// <summary>
    /// Factory for creating a connection setting DTO from a connection setting.
    /// </summary>
    public interface IConnectionSettingDtoFactory
    {
        /// <summary>
        /// Gets the type of connection setting this factory can create a connection setting DTO from.
        /// </summary>
        /// <value>
        /// The type of connection setting this factory can create a connection setting DTO from.
        /// </value>
        Type CanCreateFrom { get; }

        /// <summary>
        /// Creates a connection setting DTO from the specified connection setting.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        /// <returns>A connection setting DTO.</returns>
        ConnectionSettingDto Create(ConnectionSetting connectionSetting);
    }
}