// <copyright file="MessageBus.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    using System;

    public static class MessageBus
    {
        public static void Publish<TMessage>(TMessage message)
            where TMessage : IMessage
        {
            throw new NotImplementedException();
        }

        public static void Subscribe<TMessage>(IHandle<TMessage> subscriber)
            where TMessage : IMessage
        {
            throw new NotImplementedException();
        }
    }
}
