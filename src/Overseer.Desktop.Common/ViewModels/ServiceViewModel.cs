// <copyright file="ServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using EnsureThat;

    public abstract class ServiceViewModel : ViewModelBase
    {
        protected ServiceViewModel(string name)
        {
            EnsureArg.IsNotNullOrEmpty(name);

            Name = name;
        }

        public string Name { get; }
    }
}
