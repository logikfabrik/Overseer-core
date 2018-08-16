// <copyright file="ProjectSettingDto.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    /// <summary>
    /// DTO for project specific settings for connecting to a CI/CD service.
    /// </summary>
    /// <remarks>This class will be serialized to XML and must therefore be public and have a default constructor.</remarks>
    public sealed class ProjectSettingDto
    {
        /// <summary>
        /// Gets or sets the CI/CD project identifiers to filter by.
        /// </summary>
        /// <value>
        /// The CI/CD project identifiers to filter by.
        /// </value>
        public string[] FilterBy { get; set; }
    }
}
