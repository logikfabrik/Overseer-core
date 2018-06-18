// <copyright file="IRepository{TEntity,TIdentifier}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    using System.Linq;

    /// <summary>
    /// Represents a repository for entities.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <typeparam name="TIdentifier">The identifier type.</typeparam>
    internal interface IRepository<TEntity, in TIdentifier>
        where TEntity : IEntity<TIdentifier>
    {
        /// <summary>
        /// Gets an <see cref="IQueryable{TEntity}" /> of the entities in the repository, for further querying.
        /// </summary>
        /// <returns>An <see cref="IQueryable{TEntity}" /> of the entities in the repository.</returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Gets the entity with the specified identifier from the repository.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns>The entity with the specified identifier.</returns>
        TEntity Get(TIdentifier identifier);

        /// <summary>
        /// Adds the specified entity to the repository.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Removes the entity with specified identifier from the repository.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        void Remove(TIdentifier identifier);
    }
}