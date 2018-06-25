// <copyright file="ServiceCreatedHandle.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Services
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Handle for when a CI/CD service is created.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ServiceCreatedHandle : IHandle<ServiceCreated>
    {
        private readonly IServiceRepository _serviceRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreatedHandle" /> class.
        /// </summary>
        /// <param name="serviceRepository">The service repository.</param>
        public ServiceCreatedHandle(IServiceRepository serviceRepository)
        {
            EnsureArg.IsNotNull(serviceRepository);

            _serviceRepository = serviceRepository;
        }

        /// <inheritdoc />
        public void Handle(ServiceCreated message)
        {
            _serviceRepository.Add(message.Entity);
        }
    }
}
