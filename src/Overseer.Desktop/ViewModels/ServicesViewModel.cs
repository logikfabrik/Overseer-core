// <copyright file="ServicesViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.ViewModels
{
    using System.Collections.Generic;
    using EnsureThat;
    using Overseer.Desktop.Common.ViewModels;

    public sealed class ServicesViewModel : ViewModelBase
    {
        public ServicesViewModel(IEnumerable<ServiceViewModel> serviceViewModels)
        {
            EnsureArg.IsNotNull(serviceViewModels);

            ServiceViewModels = serviceViewModels;
        }

        public IEnumerable<ServiceViewModel> ServiceViewModels { get; }
    }
}