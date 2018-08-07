// <copyright file="CreateConnectionSettingView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.TravisCI.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class CreateConnectionSettingView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionSettingView" /> class.
        /// </summary>
        public CreateConnectionSettingView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
