// <copyright file="ViewServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using EnsureThat;

    public abstract class ViewServiceViewModel : ViewModelBase
    {
        protected ViewServiceViewModel(string name)
        {
            EnsureArg.IsNotNullOrEmpty(name);

            Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }
    }
}
