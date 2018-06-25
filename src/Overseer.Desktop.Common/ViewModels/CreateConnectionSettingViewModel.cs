﻿// <copyright file="CreateConnectionSettingViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using System;
    using System.Collections.Generic;
    using EnsureThat;
    using ReactiveUI;

    public abstract class CreateConnectionSettingViewModel : ViewModelBase
    {
        private string _name;
        private IEnumerable<string> _filterBy;
        private int _take;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionSettingViewModel" /> class.
        /// </summary>
        /// <param name="serviceId">The CI/CD service identifier.</param>
        protected CreateConnectionSettingViewModel(Guid serviceId)
        {
            EnsureArg.IsNotEmpty(serviceId);

            ServiceId = serviceId;
            Save = ReactiveCommand.Create(Create);
        }

        /// <summary>
        /// Gets the CI/CD service identifier.
        /// </summary>
        /// <value>
        /// The CI/CD service identifier.
        /// </value>
        public Guid ServiceId { get;  }

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

        protected abstract void Create();
    }
}