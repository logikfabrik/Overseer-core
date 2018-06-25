// <copyright file="ServiceCreated.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Services
{
    using System;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Event to be published when a CI/CD service is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ServiceCreated : Event<Service, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreated" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ServiceCreated(Service service)
            : base(service)
        {
        }
    }
}
