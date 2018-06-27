// <copyright file="UpdateConnectionSettingViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.ViewModels
{
    using System;
    using ReactiveUI;

    /// <summary>
    /// View model for updating settings for connecting to the AppVeyor CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class UpdateConnectionSettingViewModel : Common.ViewModels.UpdateConnectionSettingViewModel
    {
        private string _token;

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get => _token; set => this.RaiseAndSetIfChanged(ref _token, value); }

        /// <inheritdoc />
        protected override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
