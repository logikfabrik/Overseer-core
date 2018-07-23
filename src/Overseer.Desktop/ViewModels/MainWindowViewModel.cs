// <copyright file="MainWindowViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.ViewModels
{
    using Overseer.Desktop.Common.ViewModels;
    using ReactiveUI;

    public sealed class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _activeViewModel;

        public MainWindowViewModel(ServicesViewModel servicesViewModel)
        {
            ActiveViewModel = servicesViewModel;
        }

        public ViewModelBase ActiveViewModel { get => _activeViewModel; set => this.RaiseAndSetIfChanged(ref _activeViewModel, value); }
    }
}
