// <copyright file="ToConnectionSettingMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using EnsureThat;
    using Overseer.Domain.Model.ConnectionSettings;

    /// <summary>
    /// Base class for mapper for mapping a connection setting DTO to a connection setting.
    /// </summary>
    public abstract class ToConnectionSettingMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToConnectionSettingMapper" /> class.
        /// </summary>
        /// <param name="connectionSettingDto">The connection setting DTO to map.</param>
        protected ToConnectionSettingMapper(ConnectionSettingDto connectionSettingDto)
        {
            EnsureArg.IsNotNull(connectionSettingDto);

            ConnectionSettingDto = connectionSettingDto;
        }

        /// <summary>
        /// Gets the connection setting DTO to map.
        /// </summary>
        /// <value>
        /// The connection setting DTO to map.
        /// </value>
        protected ConnectionSettingDto ConnectionSettingDto { get; }

        /// <summary>
        /// Maps the connection setting DTO to a connection setting.
        /// </summary>
        /// <returns>The mapped connection setting.</returns>
        public abstract ConnectionSetting Map();
    }
}