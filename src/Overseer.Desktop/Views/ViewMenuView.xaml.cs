﻿// <copyright file="ViewMenuView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ViewMenuView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewMenuView" /> class.
        /// </summary>
        public ViewMenuView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
