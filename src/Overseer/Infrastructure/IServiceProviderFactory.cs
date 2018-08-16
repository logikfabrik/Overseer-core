// <copyright file="IServiceProviderFactory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Domain.Model.ConnectionSettings;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Represents a factory for creating service providers.
    /// </summary>
    internal interface IServiceProviderFactory
    {
        /// <summary>
        /// Creates a service provider using the specified connection setting.
        /// </summary>
        /// <param name="connectionSetting">The connection setting.</param>
        /// <returns>A service provider.</returns>
        ServiceProvider Create(ConnectionSetting connectionSetting);
    }
}
