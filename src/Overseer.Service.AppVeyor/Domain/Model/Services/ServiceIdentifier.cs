// <copyright file="ServiceIdentifier.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Domain.Model.Services
{
    using System;

    internal static class ServiceIdentifier
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public static Guid Id { get; } = Guid.Parse("1402A099-6F97-4A10-B75F-81D255F7D3EB");
    }
}
