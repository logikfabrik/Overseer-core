// <copyright file="IEventBus.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event);

        void Subscribe<TEvent>(IHandle<TEvent> subscriber);
    }
}
