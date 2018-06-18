// <copyright file="IConnectionSettingFactory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System;
    using Overseer.Domain.Model.ConnectionSettings;

    /// <summary>
    /// Factory for creating a connection setting from a connection setting DTO.
    /// </summary>
    public interface IConnectionSettingFactory
    {
        /// <summary>
        /// Gets the type of connection setting DTO this factory can create a connection setting from.
        /// </summary>
        /// <value>
        /// The type of connection setting DTO this factory can create a connection setting from.
        /// </value>
        Type CanCreateFrom { get; }

        /// <summary>
        /// Creates a connection setting from the specified connection setting DTO.
        /// </summary>
        /// <param name="connectionSettingDto">The connection setting DTO.</param>
        /// <returns>A connection setting.</returns>
        ConnectionSetting Create(ConnectionSettingDto connectionSettingDto);
    }
}