// <copyright file="EventBus.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    public class EventBus : IEventBus
    {
        public void Publish<TEvent>(TEvent @event)
        {
            throw new System.NotImplementedException();
        }

        public void Subscribe<TEvent>(IHandle<TEvent> subscriber)
        {
            throw new System.NotImplementedException();
        }
    }
}
