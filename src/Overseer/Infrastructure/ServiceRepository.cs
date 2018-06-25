// <copyright file="ServiceRepository.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using Domain.Model.Services;
    using Overseer.Common.Infrastructure;

    /// <inheritdoc cref="IServiceRepository" />
    internal sealed class ServiceRepository : MemoryRepositoy<Service, Guid>, IServiceRepository
    {
    }
}
