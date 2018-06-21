// <copyright file="IHandle{TEvent}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    public interface IHandle<TEvent>
    {
        void Handle(TEvent @event);
    }
}
