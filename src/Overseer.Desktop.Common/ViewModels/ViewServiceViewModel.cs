// <copyright file="ViewServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using EnsureThat;

    public abstract class ViewServiceViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewServiceViewModel" /> class.
        /// </summary>
        /// <param name="name">The service name.</param>
        protected ViewServiceViewModel(string name)
        {
            EnsureArg.IsNotNullOrEmpty(name);

            Name = name;
        }

        /// <summary>
        /// Gets the service name.
        /// </summary>
        /// <value>
        /// The service name.
        /// </value>
        public string Name { get; }
    }
}
