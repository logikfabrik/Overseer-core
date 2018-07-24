// <copyright file="Conductor.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    using System;
    using EnsureThat;
    using ReactiveUI;

    public abstract class Conductor : ReactiveObject, IObserver<IConductorMessage>
    {
        private IReactiveObject _activeObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductor" /> class.
        /// </summary>
        /// <param name="messageBus">The message bus.</param>
        protected Conductor(IMessageBus messageBus)
        {
            EnsureArg.IsNotNull(messageBus);

            messageBus.Listen<IConductorMessage>().Subscribe(this);
        }

        /// <summary>
        /// Gets or sets the active object.
        /// </summary>
        /// <value>
        /// The active object.
        /// </value>
        public IReactiveObject ActiveObject { get => _activeObject; set => this.RaiseAndSetIfChanged(ref _activeObject, value); }

        /// <inheritdoc />
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void OnNext(IConductorMessage value)
        {
            ActiveObject = value.ObjectToActivate;
        }
    }
}
