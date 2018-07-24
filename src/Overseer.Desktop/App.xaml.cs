// <copyright file="App.xaml.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop
{
    using Avalonia;
    using Avalonia.Markup.Xaml;

    /// <inheritdoc />
    public class App : Application
    {
        /// <inheritdoc />
        public override void Initialize()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
