// <copyright file="Event{TEntity,TIdentifier}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    /// <summary>
    /// Represents an event.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <typeparam name="TIdentifier">The identifier type.</typeparam>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class Event<TEntity, TIdentifier> : IEvent
        where TEntity : IEntity<TIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event{TEntity,TIdentifier}" /> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        protected Event(TEntity entity)
        {
            Entity = entity;
        }

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <value>
        /// The entity.
        /// </value>
        public TEntity Entity { get; }
    }
}
