// <copyright file="ToConnectionSettingMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Infrastructure
{
    using Domain.Model.ConnectionSettings;

    /// <summary>
    /// Mapper for mapping a connection setting DTO to a connection setting, for the AppVeyor CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ToConnectionSettingMapper : Common.Infrastructure.ToConnectionSettingMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToConnectionSettingMapper" /> class.
        /// </summary>
        /// <param name="connectionSettingDto">The connection setting DTO to map.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ToConnectionSettingMapper(Common.Infrastructure.ConnectionSettingDto connectionSettingDto)
            : base(connectionSettingDto)
        {
        }

        /// <inheritdoc />
        public override Overseer.Domain.Model.ConnectionSettings.ConnectionSetting Map()
        {
            var csdto = (ConnectionSettingDto)ConnectionSettingDto;

            return ConnectionSetting.Create(
                csdto.Id,
                csdto.Name,
                Overseer.Domain.Model.ConnectionSettings.ProjectSetting.Create(csdto.ProjectSetting.FilterBy),
                Overseer.Domain.Model.ConnectionSettings.BuildSetting.Create(csdto.BuildSetting.Take),
                csdto.Token);
        }
    }
}