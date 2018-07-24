// <copyright file="ConductorMessage{T}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    using ReactiveUI;

    /// <summary>
    /// A conductor message.
    /// </summary>
    /// <typeparam name="T">The type of the object to activate.</typeparam>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConductorMessage<T> : IConductorMessage
        where T : IReactiveObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorMessage{T}" /> class.
        /// </summary>
        /// <param name="objectToActivate">The object to activate.</param>
        public ConductorMessage(T objectToActivate)
        {
            ObjectToActivate = objectToActivate;
        }

        /// <summary>
        /// Gets the object to activate.
        /// </summary>
        /// <value>
        /// The object to activate.
        /// </value>
        public T ObjectToActivate { get; }

        /// <inheritdoc />
        IReactiveObject IConductorMessage.ObjectToActivate => ObjectToActivate;
    }
}
