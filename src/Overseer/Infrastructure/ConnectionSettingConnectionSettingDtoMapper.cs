// <copyright file="ConnectionSettingConnectionSettingDtoMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    public sealed class ConnectionSettingConnectionSettingDtoMapper
    {
        private readonly ConnectionSettingFactorySelector _connectionSettingFactorySelector;
        private readonly ConnectionSettingDtoFactorySelector _connectionSettingDtoFactorySelector;

        public ConnectionSettingConnectionSettingDtoMapper(
            ConnectionSettingFactorySelector connectionSettingFactorySelector,
            ConnectionSettingDtoFactorySelector connectionSettingDtoFactorySelector)
        {
            EnsureArg.IsNotNull(connectionSettingFactorySelector);
            EnsureArg.IsNotNull(connectionSettingDtoFactorySelector);

            _connectionSettingFactorySelector = connectionSettingFactorySelector;
            _connectionSettingDtoFactorySelector = connectionSettingDtoFactorySelector;
        }

        public ConnectionSetting MapFromDto(ConnectionSettingDto connectionSettingDto)
        {
            EnsureArg.IsNotNull(connectionSettingDto);

            var factory = _connectionSettingFactorySelector.Select(connectionSettingDto.GetType());

            return factory.Create(connectionSettingDto);
        }

        public ConnectionSettingDto MapToDto(ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);

            var factory = _connectionSettingDtoFactorySelector.Select(connectionSetting.GetType());

            return factory.Create(connectionSetting);
        }
    }
}
