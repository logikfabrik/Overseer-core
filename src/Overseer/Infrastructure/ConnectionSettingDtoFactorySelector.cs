// <copyright file="ConnectionSettingDtoFactorySelector.cs" company="Logikfabrik">
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
    /// Selector for selecting a connection setting DTO factory based on a specified connection setting type.
    /// </summary>
    internal sealed class ConnectionSettingDtoFactorySelector
    {
        private readonly IDictionary<Type, IConnectionSettingDtoFactory> _connectionSettingDtoFactories;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingDtoFactorySelector" /> class.
        /// </summary>
        /// <param name="connectionSettingDtoFactories">The connection setting DTO factories.</param>
        public ConnectionSettingDtoFactorySelector(IConnectionSettingDtoFactory[] connectionSettingDtoFactories)
        {
            EnsureArg.IsNotNull(connectionSettingDtoFactories);

            _connectionSettingDtoFactories = connectionSettingDtoFactories.ToDictionary(f => f.CanCreateFrom, f => f);
        }

        /// <summary>
        /// Selects the connection setting DTO factory for the specified connection setting type.
        /// </summary>
        /// <param name="connectionSettingType">The connection setting type.</param>
        /// <returns>A connection setting DTO factory.</returns>
        public IConnectionSettingDtoFactory Select(Type connectionSettingType)
        {
            EnsureArg.IsNotNull(connectionSettingType);

            return _connectionSettingDtoFactories[connectionSettingType];
        }
    }
}