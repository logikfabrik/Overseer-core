// <copyright file="IEntity{TIdentifier}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    /// <summary>
    /// Represents an entity.
    /// </summary>
    /// <typeparam name="TIdentifier">The identifier type.</typeparam>
    public interface IEntity<out TIdentifier>
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        TIdentifier Id { get; }
    }
}
