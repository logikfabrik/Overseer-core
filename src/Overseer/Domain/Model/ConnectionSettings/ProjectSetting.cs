// <copyright file="ProjectSetting.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using System.Collections.Generic;
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Project specific settings for connecting to a CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ProjectSetting : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSetting" /> class.
        /// </summary>
        /// <param name="filterBy">The CI/CD project identifiers to filter by.</param>
        private ProjectSetting(IEnumerable<string> filterBy)
        {
            var fb = filterBy as string[] ?? filterBy?.ToArray();

            EnsureArg.IsNotNull(fb);

            FilterBy = fb;
        }

        /// <summary>
        /// Gets the CI/CD project identifiers to filter by.
        /// </summary>
        /// <value>
        /// The CI/CD project identifiers to filter by.
        /// </value>
        public IEnumerable<string> FilterBy { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="ProjectSetting" /> class.
        /// </summary>
        /// <param name="filterBy">The CI/CD project identifiers to filter by.</param>
        /// <returns>A new instance of the <see cref="ProjectSetting" /> class.</returns>
        public static ProjectSetting Create(IEnumerable<string> filterBy)
        {
            return new ProjectSetting(filterBy);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ProjectSetting" /> class.
        /// </summary>
        /// <returns>A new instance of the <see cref="ProjectSetting" /> class.</returns>
        public static ProjectSetting Create()
        {
            return Create(new string[] { });
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return FilterBy.Equals(((ProjectSetting)obj).FilterBy);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return FilterBy.GetHashCode();
        }
    }
}
