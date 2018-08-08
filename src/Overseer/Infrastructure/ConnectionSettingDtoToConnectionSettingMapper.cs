// <copyright file="ConnectionSettingDtoToConnectionSettingMapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    internal sealed class ConnectionSettingDtoToConnectionSettingMapper
    {
        private readonly IToConnectionSettingMapperStrategy _connectionSettingMapperStrategy;

        public ConnectionSettingDtoToConnectionSettingMapper(IToConnectionSettingMapperStrategy connectionSettingMapperStrategy)
        {
            EnsureArg.IsNotNull(connectionSettingMapperStrategy);

            _connectionSettingMapperStrategy = connectionSettingMapperStrategy;
        }

        public ConnectionSetting Map(ConnectionSettingDto connectionSettingDto)
        {
            EnsureArg.IsNotNull(connectionSettingDto);

            var mapper = _connectionSettingMapperStrategy.Create(connectionSettingDto);

            return mapper.Map();
        }
    }
}