// <copyright file="ConnectionSettingDto.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System;

    /// <summary>
    /// Base class DTO for settings for connecting to a CI/CD service.
    /// </summary>
    public abstract class ConnectionSettingDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the project setting.
        /// </summary>
        /// <value>
        /// The project setting.
        /// </value>
        public ProjectSettingDto ProjectSetting { get; set; }

        /// <summary>
        /// Gets or sets the build setting.
        /// </summary>
        /// <value>
        /// The build setting.
        /// </value>
        public BuildSettingDto BuildSetting { get; set; }
    }
}
