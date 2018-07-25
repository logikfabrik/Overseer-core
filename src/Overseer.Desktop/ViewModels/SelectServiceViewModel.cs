// <copyright file="SelectServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.ViewModels
{
    using System.Collections.Generic;
    using EnsureThat;
    using Overseer.Desktop.Common.ViewModels;

    public sealed class SelectServiceViewModel : ViewModelBase
    {
        public SelectServiceViewModel(IEnumerable<ISelectServiceViewModel> selectServiceViewModels)
        {
            EnsureArg.IsNotNull(selectServiceViewModels);

            SelectServiceViewModels = selectServiceViewModels;
        }

        public IEnumerable<ISelectServiceViewModel> SelectServiceViewModels { get; }
    }
}