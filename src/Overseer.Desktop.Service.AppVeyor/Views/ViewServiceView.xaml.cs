// <copyright file="ViewServiceView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ViewServiceView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewServiceView" /> class.
        /// </summary>
        public ViewServiceView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
