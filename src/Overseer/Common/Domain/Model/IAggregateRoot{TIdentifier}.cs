// <copyright file="IAggregateRoot{TIdentifier}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    /// <summary>
    /// Represents an aggregate root.
    /// </summary>
    /// <typeparam name="TIdentifier">The identifier type.</typeparam>
    // ReSharper disable once InheritdocConsiderUsage
    internal interface IAggregateRoot<out TIdentifier> : IEntity<TIdentifier>
    {
    }
}
