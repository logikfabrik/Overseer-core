// <copyright file="ToConnectionSettingDtoMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using EnsureThat;
    using Overseer.Domain.Model.ConnectionSettings;

    /// <summary>
    /// Base class for mapper for mapping a connection setting to a connection setting DTO.
    /// </summary>
    public abstract class ToConnectionSettingDtoMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToConnectionSettingDtoMapper" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting to map.</param>
        protected ToConnectionSettingDtoMapper(ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);

            ConnectionSetting = connectionSetting;
        }

        /// <summary>
        /// Gets the connection setting to map.
        /// </summary>
        /// <value>
        /// The connection setting to map.
        /// </value>
        protected ConnectionSetting ConnectionSetting { get; }

        /// <summary>
        /// Maps the connection setting to a connection setting DTO.
        /// </summary>
        /// <returns>The mapped connection setting DTO.</returns>
        public abstract ConnectionSettingDto Map();
    }
}