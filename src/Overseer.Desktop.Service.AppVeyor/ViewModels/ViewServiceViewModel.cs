// <copyright file="ViewServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.ViewModels
{
    /// <summary>
    /// View model for selecting the AppVeyor CI/CD service to create a connection for.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ViewServiceViewModel : Common.ViewModels.ViewServiceViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewServiceViewModel" /> class.
        /// </summary>
        public ViewServiceViewModel()
            : base("AppVeyor")
        {
        }
    }
}
