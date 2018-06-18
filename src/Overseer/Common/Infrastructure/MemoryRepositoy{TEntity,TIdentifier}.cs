// <copyright file="MemoryRepositoy{TEntity,TIdentifier}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;
    using Domain.Model;

    /// <inheritdoc />
    internal abstract class MemoryRepositoy<TEntity, TIdentifier> : IRepository<TEntity, TIdentifier>
        where TEntity : IEntity<TIdentifier>
    {
        private readonly ISet<TEntity> _entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryRepositoy{TEntity, TIdentifier}" /> class.
        /// </summary>
        protected MemoryRepositoy()
        {
            _entities = new HashSet<TEntity>();
        }

        /// <inheritdoc />
        public IQueryable<TEntity> GetAll()
        {
            return _entities.AsQueryable();
        }

        /// <inheritdoc />
        public TEntity Get(TIdentifier identifier)
        {
            return _entities.SingleOrDefault(e => e.Id.Equals(identifier));
        }

        /// <inheritdoc />
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        /// <inheritdoc />
        public void Remove(TIdentifier identifier)
        {
            var entity = Get(identifier);

            if (entity == null)
            {
                return;
            }

            _entities.Remove(entity);
        }
    }
}
