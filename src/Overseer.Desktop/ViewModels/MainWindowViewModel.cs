// <copyright file="MainWindowViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.ViewModels
{
    using Framework;
    using ReactiveUI;

    public sealed class MainWindowViewModel : Conductor
    {
        public MainWindowViewModel(IMessageBus messageBus, ViewServicesViewModel servicesViewModel)
            : base(messageBus)
        {
            ActiveObject = servicesViewModel;
        }
    }
}
