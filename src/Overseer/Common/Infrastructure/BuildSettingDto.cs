// <copyright file="BuildSettingDto.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    /// <summary>
    /// DTO for build specific settings for connecting to a CI/CD service.
    /// </summary>
    public sealed class BuildSettingDto
    {
        /// <summary>
        /// Gets or sets the number of builds to take.
        /// </summary>
        /// <value>
        /// The number of builds to take.
        /// </value>
        public int Take { get; set; }
    }
}
