// <copyright file="BuildSetting.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents build specific settings for connecting to a CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class BuildSetting : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildSetting" /> class.
        /// </summary>
        /// <param name="take">The number of builds to take.</param>
        private BuildSetting(int take)
        {
            EnsureArg.IsInRange(take, 1, 10);

            Take = take;
        }

        /// <summary>
        /// Gets the number of builds to take.
        /// </summary>
        /// <value>
        /// The number of builds to take.
        /// </value>
        public int Take { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="BuildSetting" /> class.
        /// </summary>
        /// <param name="take">The number of builds to take.</param>
        /// <returns>A new instance of the <see cref="BuildSetting" /> class.</returns>
        public static BuildSetting Create(int take)
        {
            return new BuildSetting(take);
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

            return Take.Equals(((BuildSetting)obj).Take);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Take.GetHashCode();
        }
    }
}
