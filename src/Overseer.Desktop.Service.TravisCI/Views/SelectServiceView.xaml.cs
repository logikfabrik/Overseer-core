// <copyright file="SelectServiceView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.TravisCI.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class SelectServiceView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectServiceView" /> class.
        /// </summary>
        public SelectServiceView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
