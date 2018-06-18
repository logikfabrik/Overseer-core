using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Overseer.Desktop.ViewModels;
using Overseer.Desktop.Views;

namespace Overseer.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
