// <copyright file="Service.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Services
{
    using System;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Base class for CI/CD services.
    /// </summary>
    /// <remarks>This class has intentionally been made public.</remarks>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class Service : IAggregateRoot<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        protected Service(Guid id, string name)
        {
            EnsureArg.IsNotEmpty(id);

            Id = id;
            Name = name ?? string.Empty;
        }

        /// <inheritdoc />
        public Guid Id { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Id.Equals(((Service)obj).Id);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
