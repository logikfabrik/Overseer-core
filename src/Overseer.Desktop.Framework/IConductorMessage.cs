// <copyright file="IConductorMessage.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    using ReactiveUI;

    /// <summary>
    /// Represents a conductor message.
    /// </summary>
    public interface IConductorMessage
    {
        /// <summary>
        /// Gets the object to activate.
        /// </summary>
        /// <value>
        /// The object to activate.
        /// </value>
        IReactiveObject ObjectToActivate { get; }
    }
}