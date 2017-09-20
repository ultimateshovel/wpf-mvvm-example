namespace WpfApp.Infrastructure
{
    using System.Windows;
    using Modules;
    using Ninject;
    using Prism.Modularity;
    using Prism.Ninject;
    public class CustomNinjectBootstrapper : NinjectBootstrapper
    {
        // add text and button modules to ninject's catalog

        protected override DependencyObject CreateShell()
        {
            return Kernel.Get< Views.Shell >();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();

//            Kernel.Get< IEventAggregator >()
//                .GetEvent< RegionManagerEvent< IRegionRequest > >()
//                .Subscribe();
        }


        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            var textModule = typeof( TextModule );
            var buttonModule = typeof( ButtonModule );

            ModuleCatalog.AddModule(new ModuleInfo(textModule.Name, textModule.AssemblyQualifiedName));
            ModuleCatalog.AddModule(new ModuleInfo(buttonModule.Name, buttonModule.AssemblyQualifiedName));
        }
    }
}
