// <copyright file="ServiceIdentifier.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.TravisCI.Domain.Model.Services
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
        public static Guid Id { get; } = Guid.Parse("A5B8549D-1736-459C-ADF2-AF5D26E2F550");
    }
}
