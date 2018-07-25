// <copyright file="SelectServiceViewModel{T}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using EnsureThat;
    using Framework;
    using ReactiveUI;

    /// <summary>
    /// Base class for view models for selecting a CI/CD service to create a connection for.
    /// </summary>
    /// <typeparam name="T">The type of the view model (which will be used to create a connection) to activate, if the service is selected.</typeparam>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class SelectServiceViewModel<T> : ViewModelBase, ISelectServiceViewModel
        where T : CreateConnectionSettingViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectServiceViewModel{T}" /> class.
        /// </summary>
        /// <param name="messageBus">The message bus.</param>
        /// <param name="createConnectionConductorMessageFactory">The create connection conductor message factory.</param>
        /// <param name="name">The name.</param>
        protected SelectServiceViewModel(IMessageBus messageBus, IConductorMessageFactory<T> createConnectionConductorMessageFactory, string name)
        {
            EnsureArg.IsNotNull(messageBus);
            EnsureArg.IsNotNull(createConnectionConductorMessageFactory);
            EnsureArg.IsNotNullOrEmpty(name);

            Select = ReactiveCommand.Create(() => messageBus.SendMessage((IConductorMessage)createConnectionConductorMessageFactory.Create()));
            Name = name;
        }

        /// <summary>
        /// Gets the service name.
        /// </summary>
        /// <value>
        /// The service name.
        /// </value>
        public string Name { get; }

        /// <inheritdoc />
        public ReactiveCommand Select { get; }
    }
}