// <copyright file="IServiceProviderFactory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using Overseer.Domain.Model.ConnectionSettings;

    internal interface IServiceProviderFactory
    {
        IServiceProvider Create(ConnectionSetting connectionSetting);
    }
}
