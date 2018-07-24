// <copyright file="ViewDashboardView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ViewDashboardView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDashboardView" /> class.
        /// </summary>
        public ViewDashboardView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
