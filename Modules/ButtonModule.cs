namespace WpfApp.Modules
{
    #region Usings

    using System;
    using Ninject;
    using Prism.Modularity;
    using Prism.Regions;
    using Views;

    #endregion

    public class ButtonModule : IModule
    {
        #region Fields

        private readonly IRegionViewRegistry _regionViewRegistry;
        private readonly IRegionManager _regionManager;

        #endregion

        #region Constructors

        public ButtonModule( IRegionViewRegistry registry, IRegionManager manager )
        {
            _regionViewRegistry = registry;
            _regionManager = manager;

        }

        #endregion

        #region Interface Implementations

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion
                ( "ButtonRegion", typeof( ButtonView ) );
        }

        #endregion
    }
}