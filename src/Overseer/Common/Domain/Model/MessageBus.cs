// <copyright file="MessageBus.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EnsureThat;

    /// <summary>
    /// Message bus for domain messages.
    /// </summary>
    /// <remarks>This class has intentionally been made public.</remarks>
    public static class MessageBus
    {
        private static readonly IDictionary<Type, ISet<object>> Subscribers = new Dictionary<Type, ISet<object>>();

        public static void Publish<TMessage>(TMessage message)
            where TMessage : IMessage
        {
            if (!Subscribers.TryGetValue(typeof(TMessage), out var subscribers))
            {
                return;
            }

            foreach (var subscriber in subscribers.Cast<IHandle<TMessage>>())
            {
                subscriber.Handle(message);
            }
        }

        public static void Subscribe<TMessage>(IHandle<TMessage> subscriber)
            where TMessage : IMessage
        {
            EnsureArg.IsNotNull(subscriber);

            if (Subscribers.TryGetValue(typeof(TMessage), out var subscribers))
            {
                subscribers.Add(subscriber);
            }
            else
            {
                Subscribers.Add(typeof(TMessage), new HashSet<object>(new[] { subscriber }));
            }
        }
    }
}