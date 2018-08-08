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
        private readonly IToConnectionSettingMapperFactory _connectionSettingMapperFactory;

        public ConnectionSettingDtoToConnectionSettingMapper(IToConnectionSettingMapperFactory connectionSettingMapperFactory)
        {
            EnsureArg.IsNotNull(connectionSettingMapperFactory);

            _connectionSettingMapperFactory = connectionSettingMapperFactory;
        }

        public ConnectionSetting Map(ConnectionSettingDto connectionSettingDto)
        {
            EnsureArg.IsNotNull(connectionSettingDto);

            var mapper = _connectionSettingMapperFactory.Create(connectionSettingDto);

            return mapper.Map();
        }
    }
}