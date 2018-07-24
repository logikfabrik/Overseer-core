﻿// <copyright file="ViewServicesView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ViewServicesView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewServicesView" /> class.
        /// </summary>
        public ViewServicesView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
