// <copyright file="ViewMenuViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.ViewModels
{
    using EnsureThat;
    using Framework;
    using Overseer.Desktop.Common.ViewModels;
    using ReactiveUI;

    public sealed class ViewMenuViewModel : ViewModelBase
    {
        public ViewMenuViewModel(
            IMessageBus messageBus,
            IConductorMessageFactory<ViewDashboardViewModel> viewDashboardConductorMessageFactory,
            IConductorMessageFactory<ViewConnectionsViewModel> viewConnectionsConductorMessageFactory,
            IConductorMessageFactory<UpdateSettingsViewModel> updateSettingsConductorMessageFactory,
            IConductorMessageFactory<ViewAboutViewModel> viewAboutConductorMessageFactory)
        {
            EnsureArg.IsNotNull(messageBus);
            EnsureArg.IsNotNull(viewDashboardConductorMessageFactory);
            EnsureArg.IsNotNull(viewConnectionsConductorMessageFactory);
            EnsureArg.IsNotNull(updateSettingsConductorMessageFactory);
            EnsureArg.IsNotNull(viewAboutConductorMessageFactory);

            ViewDashboard = ReactiveCommand.Create(() => messageBus.SendMessage((IConductorMessage)viewDashboardConductorMessageFactory.Create()));
            ViewConnections = ReactiveCommand.Create(() => messageBus.SendMessage((IConductorMessage)viewConnectionsConductorMessageFactory.Create()));
            UpdateSettings = ReactiveCommand.Create(() => messageBus.SendMessage((IConductorMessage)updateSettingsConductorMessageFactory.Create()));
            ViewAbout = ReactiveCommand.Create(() => messageBus.SendMessage((IConductorMessage)viewAboutConductorMessageFactory.Create()));
        }

        public ReactiveCommand ViewDashboard { get; }

        public ReactiveCommand ViewConnections { get; }

        public ReactiveCommand UpdateSettings { get; }

        public ReactiveCommand ViewAbout { get; }
    }
}
