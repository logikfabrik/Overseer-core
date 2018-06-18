﻿// <copyright file="ProjectSettingDto.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System.Collections.Generic;

    /// <summary>
    /// DTO for project specific settings for connecting to a CI/CD service.
    /// </summary>
    public sealed class ProjectSettingDto
    {
        /// <summary>
        /// Gets or sets the CI/CD project identifiers to filter by.
        /// </summary>
        /// <value>
        /// The CI/CD project identifiers to filter by.
        /// </value>
        public IEnumerable<string> FilterBy { get; set; }
    }
}