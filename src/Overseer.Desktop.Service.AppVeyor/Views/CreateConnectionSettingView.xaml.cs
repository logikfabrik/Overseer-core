// <copyright file="CreateConnectionSettingView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class CreateConnectionSettingView : UserControl
    {
        public CreateConnectionSettingView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
