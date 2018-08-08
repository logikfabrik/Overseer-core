// <copyright file="ConnectionSettingToConnectionSettingDtoMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    internal sealed class ConnectionSettingToConnectionSettingDtoMapper
    {
        private readonly IToConnectionSettingDtoMapperStrategy _connectionSettingDtoMapperStrategy;

        public ConnectionSettingToConnectionSettingDtoMapper(IToConnectionSettingDtoMapperStrategy connectionSettingDtoMapperStrategy)
        {
            EnsureArg.IsNotNull(connectionSettingDtoMapperStrategy);

            _connectionSettingDtoMapperStrategy = connectionSettingDtoMapperStrategy;
        }

        public ConnectionSettingDto Map(ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);

            var mapper = _connectionSettingDtoMapperStrategy.Create(connectionSetting);

            return mapper.Map();
        }
    }
}
