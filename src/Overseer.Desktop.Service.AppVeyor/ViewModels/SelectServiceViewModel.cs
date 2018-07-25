// <copyright file="SelectServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.ViewModels
{
    using Framework;
    using ReactiveUI;

    /// <summary>
    /// View model for selecting the AppVeyor CI/CD service to create a connection for.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class SelectServiceViewModel : Common.ViewModels.SelectServiceViewModel<CreateConnectionSettingViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectServiceViewModel" /> class.
        /// </summary>
        /// <param name="messageBus">The message bus.</param>
        /// <param name="createConnectionConductorMessageFactory">The create connection conductor message factory.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public SelectServiceViewModel(IMessageBus messageBus, IConductorMessageFactory<CreateConnectionSettingViewModel> createConnectionConductorMessageFactory)
            : base(messageBus, createConnectionConductorMessageFactory, "AppVeyor")
        {
        }
    }
}
