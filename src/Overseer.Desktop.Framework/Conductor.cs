// <copyright file="Conductor.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Framework
{
    using System;
    using EnsureThat;
    using ReactiveUI;

    /// <summary>
    /// A conductor allows for objects to be activated one at a time.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class Conductor : ReactiveObject, IObserver<IConductorMessage>, IDisposable
    {
        private readonly IDisposable _conductorMessageSubscription;
        private IReactiveObject _activeObject;
        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductor" /> class.
        /// </summary>
        /// <param name="messageBus">The message bus.</param>
        protected Conductor(IMessageBus messageBus)
        {
            EnsureArg.IsNotNull(messageBus);

            _conductorMessageSubscription = messageBus.Listen<IConductorMessage>().Subscribe(this);
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

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _conductorMessageSubscription.Dispose();
            }

            _disposed = true;
        }
    }
}