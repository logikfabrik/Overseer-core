// <copyright file="IHandle{TMessage}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    /// <summary>
    /// Represents a handle for messages, both events and commands.
    /// </summary>
    /// <typeparam name="TMessage">The message type.</typeparam>
    public interface IHandle<in TMessage>
        where TMessage : IMessage
    {
        /// <summary>
        /// Handles the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Handle(TMessage message);
    }
}
