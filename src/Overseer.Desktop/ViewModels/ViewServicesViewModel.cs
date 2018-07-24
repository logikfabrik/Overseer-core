// <copyright file="ViewServicesViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.ViewModels
{
    using System.Collections.Generic;
    using EnsureThat;
    using Overseer.Desktop.Common.ViewModels;

    public sealed class ViewServicesViewModel : ViewModelBase
    {
        public ViewServicesViewModel(IEnumerable<ViewServiceViewModel> viewServiceViewModels)
        {
            EnsureArg.IsNotNull(viewServiceViewModels);

            ViewServiceViewModels = viewServiceViewModels;
        }

        public IEnumerable<ViewServiceViewModel> ViewServiceViewModels { get; }
    }
}