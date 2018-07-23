// <copyright file="ServicesView.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class ServicesView : UserControl
    {
        public ServicesView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
