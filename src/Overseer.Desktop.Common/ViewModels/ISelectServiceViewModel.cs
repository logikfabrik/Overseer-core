// <copyright file="ISelectServiceViewModel.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Common.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// Represents a view model for selecting a CI/CD service to create a connection for.
    /// </summary>
    public interface ISelectServiceViewModel
    {
        ReactiveCommand Select { get; }
    }
}
