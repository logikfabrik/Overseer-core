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
        ServiceProvider Create(ConnectionSetting connectionSetting);
    }
}
