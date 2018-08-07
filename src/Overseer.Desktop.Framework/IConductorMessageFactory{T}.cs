// <copyright file="IConductorMessageFactory{T}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    using ReactiveUI;

    /// <summary>
    /// Represents a factory for creating conductor messages.
    /// </summary>
    /// <typeparam name="T">The type of the object to activate.</typeparam>
    public interface IConductorMessageFactory<T>
        where T : IReactiveObject
    {
        /// <summary>
        /// Creates a conductor message. A new instance of the type of object to activate will be created.
        /// </summary>
        /// <returns>A conductor message.</returns>
        ConductorMessage<T> Create();

        /// <summary>
        /// Creates a conductor message for the specified object to activate.
        /// </summary>
        /// <param name="objectToActivate">The object to activate.</param>
        /// <returns>A conductor message.</returns>
        ConductorMessage<T> Create(T objectToActivate);
    }
}
