// <copyright file="Program.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop
{
    using Avalonia;
    using Avalonia.Logging.Serilog;
    using Framework;
    using Ninject;
    using Ninject.Extensions.Factory;
    using ReactiveUI;
    using Splat;
    using ViewModels;
    using Views;

    public class Program
    {
        public static void Main(string[] args)
        {
            Locator.Current = GetResolver();

            var bootstrapper = Locator.Current.GetService<Bootstrapper>();

            bootstrapper.Run();

            var appBuilder = BuildAvaloniaApp();

            appBuilder.Start<MainWindow>(() => Locator.Current.GetService<MainWindowViewModel>());
        }

        private static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
        }

        private static FuncDependencyResolver GetResolver()
        {
            var kernel = new StandardKernel();

            if (!kernel.HasModule(new FuncModule().Name))
            {
                kernel = new StandardKernel(new FuncModule());
            }

            kernel.Load("Overseer*.dll");

            kernel.Bind<IMessageBus>().ToConstant(MessageBus.Current);
            kernel.Bind<IConductorMessageFactory<ViewDashboardViewModel>>().ToFactory();
            kernel.Bind<IConductorMessageFactory<ViewConnectionsViewModel>>().ToFactory();
            kernel.Bind<IConductorMessageFactory<SelectServiceViewModel>>().ToFactory();
            kernel.Bind<IConductorMessageFactory<UpdateSettingsViewModel>>().ToFactory();
            kernel.Bind<IConductorMessageFactory<ViewAboutViewModel>>().ToFactory();

            return new FuncDependencyResolver(
                (service, contract) => contract != null ? kernel.GetAll(service, contract) : kernel.GetAll(service),
                (factory, service, contract) =>
                {
                    var binding = kernel.Bind(service).ToMethod(_ => factory());

                    if (contract != null)
                    {
                        binding.Named(contract);
                    }
                });
        }
    }
}
