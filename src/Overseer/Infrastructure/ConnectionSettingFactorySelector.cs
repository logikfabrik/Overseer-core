// <copyright file="ConnectionSettingFactorySelector.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Selector for selecting a connection setting factory based on a specified connection setting DTO type.
    /// </summary>
    internal sealed class ConnectionSettingFactorySelector
    {
        private readonly IDictionary<Type, IConnectionSettingFactory> _connectionSettingFactories;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingFactorySelector" /> class.
        /// </summary>
        /// <param name="connectionSettingFactories">The connection setting factories.</param>
        public ConnectionSettingFactorySelector(IConnectionSettingFactory[] connectionSettingFactories)
        {
            EnsureArg.IsNotNull(connectionSettingFactories);

            _connectionSettingFactories = connectionSettingFactories.ToDictionary(f => f.CanCreateFrom, f => f);
        }

        /// <summary>
        /// Selects the connection setting factory for the specified connection setting DTO type.
        /// </summary>
        /// <param name="connectionSettingType">The connection setting DTO type.</param>
        /// <returns>A connection setting factory.</returns>
        public IConnectionSettingFactory Select(Type connectionSettingType)
        {
            EnsureArg.IsNotNull(connectionSettingType);

            return _connectionSettingFactories[connectionSettingType];
        }
    }
}
