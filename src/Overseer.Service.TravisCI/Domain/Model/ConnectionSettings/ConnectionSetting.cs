// <copyright file="ConnectionSetting.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.TravisCI.Domain.Model.ConnectionSettings
{
    using System;
    using EnsureThat;
    using Overseer.Common.Domain.Model;
    using Overseer.Domain.Model.ConnectionSettings;
    using Services;

    /// <summary>
    /// Settings for connecting to the TravisCI CI/CD service.
    /// </summary>
    /// <remarks>This class has intentionally been made public.</remarks>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConnectionSetting : Overseer.Domain.Model.ConnectionSettings.ConnectionSetting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSetting" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="projectSetting">The project setting.</param>
        /// <param name="buildSetting">The build setting.</param>
        /// <param name="token">The token.</param>
        // ReSharper disable once InheritdocConsiderUsage
        private ConnectionSetting(Guid id, string name, ProjectSetting projectSetting, BuildSetting buildSetting, string token)
            : base(id, ServiceIdentifier.Id, name, projectSetting, buildSetting)
        {
            EnsureArg.IsNotNullOrEmpty(token);

            Token = token;
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="ConnectionSetting" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="token">The token.</param>
        /// <returns>A new instance of the <see cref="ConnectionSetting" /> class.</returns>
        public static ConnectionSetting Create(string name, string token)
        {
            var connectionSetting = new ConnectionSetting(Guid.NewGuid(), name, ProjectSetting.Create(), BuildSetting.Create(), token);

            MessageBus.Publish(new ConnectionSettingCreated(connectionSetting));

            return connectionSetting;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ConnectionSetting" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="projectSetting">The project setting.</param>
        /// <param name="buildSetting">The build setting.</param>
        /// <param name="token">The token.</param>
        /// <returns>A new instance of the <see cref="ConnectionSetting" /> class.</returns>
        public static ConnectionSetting Create(Guid id, string name, ProjectSetting projectSetting, BuildSetting buildSetting, string token)
        {
            var connectionSetting = new ConnectionSetting(id, name, projectSetting, buildSetting, token);

            MessageBus.Publish(new ConnectionSettingCreated(connectionSetting));

            return connectionSetting;
        }

        /// <summary>
        /// Changes the token.
        /// </summary>
        /// <param name="token">The token to change to.</param>
        public void ChangeToken(string token)
        {
            EnsureArg.IsNotNullOrEmpty(token);

            Token = token;

            MessageBus.Publish(new ConnectionSettingChanged(this));
        }
    }
}