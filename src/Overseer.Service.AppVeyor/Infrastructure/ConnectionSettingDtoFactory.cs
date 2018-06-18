// <copyright file="ConnectionSettingDtoFactory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Infrastructure
{
    using System;
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Factory for creating a connection setting DTO from a connection setting, for the AppVeyor CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConnectionSettingDtoFactory : IConnectionSettingDtoFactory
    {
        /// <inheritdoc />
        public Type CanCreateFrom { get; } = typeof(ConnectionSetting);

        /// <inheritdoc />
        public Common.Infrastructure.ConnectionSettingDto Create(Overseer.Domain.Model.ConnectionSettings.ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);

            var cs = (ConnectionSetting)connectionSetting;

            return new ConnectionSettingDto
            {
                Id = cs.Id,
                ProjectSetting = new ProjectSettingDto
                {
                    FilterBy = cs.ProjectSetting.FilterBy
                },
                BuildSetting = new BuildSettingDto
                {
                    Take = cs.BuildSetting.Take
                },
                Token = cs.Token
            };
        }
    }
}
