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
        private readonly IToConnectionSettingDtoMapperFactory _connectionSettingDtoMapperFactory;

        public ConnectionSettingToConnectionSettingDtoMapper(IToConnectionSettingDtoMapperFactory connectionSettingDtoMapperFactory)
        {
            EnsureArg.IsNotNull(connectionSettingDtoMapperFactory);

            _connectionSettingDtoMapperFactory = connectionSettingDtoMapperFactory;
        }

        public ConnectionSettingDto Map(ConnectionSetting connectionSetting)
        {
            EnsureArg.IsNotNull(connectionSetting);

            var mapper = _connectionSettingDtoMapperFactory.Create(connectionSetting);

            return mapper.Map();
        }
    }
}
