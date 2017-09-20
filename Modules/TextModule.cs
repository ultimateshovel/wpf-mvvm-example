namespace WpfApp.Modules
{
    #region Usings

    using Prism.Modularity;
    using Prism.Regions;
    using Views;

    #endregion

    public class TextModule : IModule
    {
        #region Fields

        private readonly IRegionViewRegistry _regionViewRegistry;

        #endregion

        #region Constructors

        public TextModule( IRegionViewRegistry registry )
        {
            _regionViewRegistry = registry;
        }

        #endregion

        #region Interface Implementations

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion
                ( "TextRegion", typeof( TextView ) );
        }

        #endregion
    }
}