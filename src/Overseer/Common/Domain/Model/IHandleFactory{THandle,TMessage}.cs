// <copyright file="IHandleFactory{THandle,TMessage}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    internal interface IHandleFactory<out THandle, TMessage>
        where THandle : IHandle<TMessage>
        where TMessage : IMessage
    {
        THandle Create();
    }
}
