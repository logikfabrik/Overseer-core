// <copyright file="ViewLocator.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop
{
    using System;
    using Avalonia.Controls;
    using Avalonia.Controls.Templates;
    using Overseer.Desktop.Common.ViewModels;
    using Splat;

    /// <summary>
    /// A template for locating and building views for view models.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public class ViewLocator : IDataTemplate
    {
        /// <inheritdoc />
        public bool SupportsRecycling => false;

        /// <inheritdoc />
        public IControl Build(object data)
        {
            var viewModelType = data.GetType();
            var viewModelTypeName = viewModelType.FullName;

            var viewTypeAssemblyQualifiedName = viewModelType.AssemblyQualifiedName.Replace(viewModelTypeName, viewModelTypeName.Replace("ViewModel", "View"));
            var viewType = Type.GetType(viewTypeAssemblyQualifiedName);

            if (viewType != null)
            {
                return Locator.Current.GetService(viewType) as IControl;
            }

            return new TextBlock { Text = $"Could not find view for view model of type '{viewTypeAssemblyQualifiedName}'." };
        }

        /// <inheritdoc />
        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}