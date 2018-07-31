// <copyright file="CreateConnectionSettingViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// Base class for view models for creating settings for connecting to a CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class CreateConnectionSettingViewModel : ViewModelBase
    {
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionSettingViewModel" /> class.
        /// </summary>
        protected CreateConnectionSettingViewModel()
        {
            Save = ReactiveCommand.Create(Create);
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => _name; set => this.RaiseAndSetIfChanged(ref _name, value); }

        public ReactiveCommand Save { get; }

        protected abstract void Create();
    }
}
