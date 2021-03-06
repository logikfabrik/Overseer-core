﻿// <copyright file="Service.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Domain.Model.Services
{
    using Overseer.Common.Domain.Model;
    using Overseer.Domain.Model.Services;

    /// <summary>
    /// The AppVeyor CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class Service : Overseer.Domain.Model.Services.Service
    {
        private Service()
            : base(ServiceIdentifier.Id, "AppVeyor")
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Service" /> class.
        /// </summary>
        /// <returns>A new instance of the <see cref="Service" /> class.</returns>
        public static Service Create()
        {
            var service = new Service();

            MessageBus.Publish(new ServiceCreated(service));

            return service;
        }
    }
}
