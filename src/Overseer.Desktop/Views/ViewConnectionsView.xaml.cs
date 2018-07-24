// <copyright file="ViewConnectionsView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ViewConnectionsView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewConnectionsView" /> class.
        /// </summary>
        public ViewConnectionsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
