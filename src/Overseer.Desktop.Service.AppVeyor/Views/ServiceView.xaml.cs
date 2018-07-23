// <copyright file="ServiceView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Service.AppVeyor.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ServiceView : UserControl
    {
        public ServiceView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
