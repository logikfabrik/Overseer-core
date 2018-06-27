// <copyright file="ConnectionSettingFactory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Infrastructure
{
    using System;
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Factory for creating a connection setting from a connection setting DTO, for the AppVeyor CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConnectionSettingFactory : IConnectionSettingFactory
    {
        /// <inheritdoc />
        public Type CanCreateFrom { get; } = typeof(ConnectionSetting);

        /// <inheritdoc />
        public Overseer.Domain.Model.ConnectionSettings.ConnectionSetting Create(Common.Infrastructure.ConnectionSettingDto connectionSettingDto)
        {
            EnsureArg.IsNotNull(connectionSettingDto);

            var csdto = (ConnectionSettingDto)connectionSettingDto;

            return ConnectionSetting.Create(
                csdto.Id,
                csdto.Name,
                Overseer.Domain.Model.ConnectionSettings.ProjectSetting.Create(csdto.ProjectSetting.FilterBy),
                Overseer.Domain.Model.ConnectionSettings.BuildSetting.Create(csdto.BuildSetting.Take),
                csdto.Token);
        }
    }
}
