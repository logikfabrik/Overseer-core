// <copyright file="ConnectionSetting.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.ConnectionSettings
{
    using System;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Base class for settings for connecting to a CI/CD service.
    /// </summary>
    /// <remarks>This class has intentionally been made public.</remarks>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class ConnectionSetting : IAggregateRoot<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSetting" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="serviceId">The CI/CD service identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="projectSetting">The project setting.</param>
        /// <param name="buildSetting">The build setting.</param>
        protected ConnectionSetting(Guid id, Guid serviceId, string name, ProjectSetting projectSetting, BuildSetting buildSetting)
        {
            EnsureArg.IsNotEmpty(id);
            EnsureArg.IsNotEmpty(serviceId);
            EnsureArg.IsNotNull(projectSetting);
            EnsureArg.IsNotNull(buildSetting);

            Id = id;
            ServiceId = serviceId;
            Name = name ?? string.Empty;
            ProjectSetting = projectSetting;
            BuildSetting = buildSetting;
        }

        /// <inheritdoc />
        public Guid Id { get; }

        /// <summary>
        /// Gets the CI/CD service identifier.
        /// </summary>
        /// <value>
        /// The CI/CD service identifier.
        /// </value>
        public Guid ServiceId { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the project setting.
        /// </summary>
        /// <value>
        /// The project setting.
        /// </value>
        public ProjectSetting ProjectSetting { get; private set; }

        /// <summary>
        /// Gets the build setting.
        /// </summary>
        /// <value>
        /// The build setting.
        /// </value>
        public BuildSetting BuildSetting { get; private set; }

        /// <summary>
        /// Renames the connection setting.
        /// </summary>
        /// <param name="name">The name to change to.</param>
        public void Rename(string name)
        {
            Name = name ?? string.Empty;

            MessageBus.Publish(new ConnectionSettingRenamed(this));
        }

        /// <summary>
        /// Changes the project setting.
        /// </summary>
        /// <param name="projectSetting">The project setting to change to.</param>
        public void ChangeProjectSetting(ProjectSetting projectSetting)
        {
            EnsureArg.IsNotNull(projectSetting);

            ProjectSetting = projectSetting;

            MessageBus.Publish(new ConnectionSettingChanged(this));
        }

        /// <summary>
        /// Changes the build setting.
        /// </summary>
        /// <param name="buildSetting">The build setting to change to.</param>
        public void ChangeBuildSetting(BuildSetting buildSetting)
        {
            EnsureArg.IsNotNull(buildSetting);

            BuildSetting = buildSetting;

            MessageBus.Publish(new ConnectionSettingChanged(this));
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

            return Id.Equals(((ConnectionSetting)obj).Id);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
