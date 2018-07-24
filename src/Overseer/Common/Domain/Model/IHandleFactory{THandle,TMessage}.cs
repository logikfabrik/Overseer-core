// <copyright file="IHandleFactory{THandle,TMessage}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    /// <summary>
    /// Represents a factory for creating handles.
    /// </summary>
    /// <typeparam name="THandle">The type of the handle.</typeparam>
    /// <typeparam name="TMessage">The type of the message.</typeparam>
    internal interface IHandleFactory<out THandle, TMessage>
        where THandle : IHandle<TMessage>
        where TMessage : IMessage
    {
        /// <summary>
        /// Creates a handle.
        /// </summary>
        /// <returns>A handle.</returns>
        THandle Create();
    }
}
