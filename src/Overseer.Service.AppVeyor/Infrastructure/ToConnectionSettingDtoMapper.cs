// <copyright file="ToConnectionSettingDtoMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Infrastructure
{
    using Domain.Model.ConnectionSettings;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Mapper for mapping a connection setting to a connection setting DTO, for the AppVeyor CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ToConnectionSettingDtoMapper : Common.Infrastructure.ToConnectionSettingDtoMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToConnectionSettingDtoMapper" /> class.
        /// </summary>
        /// <param name="connectionSetting">The connection setting to map.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ToConnectionSettingDtoMapper(Overseer.Domain.Model.ConnectionSettings.ConnectionSetting connectionSetting)
            : base(connectionSetting)
        {
        }

        /// <inheritdoc />
        public override Common.Infrastructure.ConnectionSettingDto Map()
        {
            var cs = (ConnectionSetting)ConnectionSetting;

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
