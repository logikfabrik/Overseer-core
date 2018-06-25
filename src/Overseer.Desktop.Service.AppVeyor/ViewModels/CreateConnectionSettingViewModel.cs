// <copyright file="CreateConnectionSettingViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.ViewModels
{
    using System;
    using Domain.Model.ConnectionSettings;
    using ReactiveUI;

    public class CreateConnectionSettingViewModel : Common.ViewModels.CreateConnectionSettingViewModel
    {
        private string _token;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionSettingViewModel" /> class.
        /// </summary>
        /// <param name="serviceId">The CI/CD service identifier.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public CreateConnectionSettingViewModel(Guid serviceId)
            : base(serviceId)
        {
        }

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
            Overseer.Service.AppVeyor.Domain.Model.ConnectionSettings.ConnectionSetting.Create(ServiceId, Name, ProjectSetting.Create(FilterBy), BuildSetting.Create(Take), Token);
        }
    }
}
