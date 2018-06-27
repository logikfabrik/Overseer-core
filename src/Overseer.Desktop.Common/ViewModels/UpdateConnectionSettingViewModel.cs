// <copyright file="UpdateConnectionSettingViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using System.Collections.Generic;
    using ReactiveUI;

    /// <summary>
    /// Base class for view models for updating settings for connecting to a CI/CD service.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public abstract class UpdateConnectionSettingViewModel : ViewModelBase
    {
        private string _name;
        private IEnumerable<string> _filterBy;
        private int _take;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectionSettingViewModel" /> class.
        /// </summary>
        protected UpdateConnectionSettingViewModel()
        {
            Save = ReactiveCommand.Create(Update);
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => _name; set => this.RaiseAndSetIfChanged(ref _name, value); }

        /// <summary>
        /// Gets or sets the CI/CD project identifiers to filter projects by.
        /// </summary>
        /// <value>
        /// The CI/CD project identifiers to filter projects by.
        /// </value>
        public IEnumerable<string> FilterBy { get => _filterBy; set => this.RaiseAndSetIfChanged(ref _filterBy, value); }

        /// <summary>
        /// Gets or sets the number of builds to take.
        /// </summary>
        /// <value>
        /// The number of builds to take.
        /// </value>
        public int Take { get => _take; set => this.RaiseAndSetIfChanged(ref _take, value); }

        public ReactiveCommand Save { get; }

        protected abstract void Update();
    }
}
