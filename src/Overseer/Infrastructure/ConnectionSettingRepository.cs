// <copyright file="ConnectionSettingRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Domain.Model.ConnectionSettings;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    /// <inheritdoc cref="IConnectionSettingRepository" />
    internal sealed class ConnectionSettingRepository : IConnectionSettingRepository
    {
        private readonly ConnectionSettingDtoFile _connectionSettingDtoFile;
        private readonly IToConnectionSettingDtoMapperFactory _toConnectionSettingDtoMapperFactory;
        private readonly IToConnectionSettingMapperFactory _toConnectionSettingMapperFactory;
        private readonly HashSet<ConnectionSetting> _connectionSettings;

        public ConnectionSettingRepository(
            ConnectionSettingDtoFile connectionSettingDtoFile,
            IToConnectionSettingDtoMapperFactory toConnectionSettingDtoMapperFactory,
            IToConnectionSettingMapperFactory toConnectionSettingMapperFactory)
        {
            EnsureArg.IsNotNull(connectionSettingDtoFile);
            EnsureArg.IsNotNull(toConnectionSettingDtoMapperFactory);
            EnsureArg.IsNotNull(toConnectionSettingMapperFactory);

            _connectionSettingDtoFile = connectionSettingDtoFile;
            _toConnectionSettingDtoMapperFactory = toConnectionSettingDtoMapperFactory;
            _toConnectionSettingMapperFactory = toConnectionSettingMapperFactory;

            _connectionSettings = new HashSet<ConnectionSetting>();

            foreach (var connectionSettingDto in _connectionSettingDtoFile.Read())
            {
                var mapper = _toConnectionSettingMapperFactory.Create(connectionSettingDto);

                var connectionSetting = mapper.Map();

                _connectionSettings.Add(connectionSetting);
            }
        }

        public IQueryable<ConnectionSetting> GetAll()
        {
            return _connectionSettings.AsQueryable();
        }

        public ConnectionSetting Get(Guid identifier)
        {
            return _connectionSettings.SingleOrDefault(connectionSetting => connectionSetting.Id == identifier);
        }

        public void Add(ConnectionSetting entity)
        {
            _connectionSettings.Add(entity);

            Save();
        }

        public void Remove(Guid identifier)
        {
            _connectionSettings.RemoveWhere(connectionSetting => connectionSetting.Id == identifier);
        }

        private void Load()
        {

        }

        private void Save()
        {
            var connectionSettings = new HashSet<ConnectionSettingDto>();

            foreach (var connectionSetting in _connectionSettings)
            {
                var mapper = _toConnectionSettingDtoMapperFactory.Create(connectionSetting);

                var connectionSettingDto = mapper.Map();

                connectionSettings.Add(connectionSettingDto);
            }

            _connectionSettingDtoFile.Write(connectionSettings.ToArray());
        }
    }
}
