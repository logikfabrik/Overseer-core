// <copyright file="UpdateSettingsView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class UpdateSettingsView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsView" /> class.
        /// </summary>
        public UpdateSettingsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
