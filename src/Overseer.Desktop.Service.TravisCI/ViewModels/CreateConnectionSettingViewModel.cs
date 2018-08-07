// <copyright file="CreateConnectionSettingViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.TravisCI.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// View model for creating settings for connecting to the TravisCI CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class CreateConnectionSettingViewModel : Common.ViewModels.CreateConnectionSettingViewModel
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
        protected override void Create()
        {
            Overseer.Service.TravisCI.Domain.Model.ConnectionSettings.ConnectionSetting.Create(Name, Token);
        }
    }
}
