using Prism.Ioc;
using MiddleLayout_Semiconductor.Views;
using System.Windows;
using Prism.Modularity;
using MiddleLayout_Semiconductor.Module;
using Prism.Regions;

namespace MiddleLayout_Semiconductor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanelEx), Container.Resolve<MainViewAdapter>());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">do not support system.windows.form, but you can create wpf control that include any control from winform</typeparam>
        /// <param name="enumer"></param>
        public void RegisterNavigation<T>(ControllerNavigations enumer) where T : System.Windows.UIElement
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<MainModule>();
        }
    }

    public enum ControllerNavigations
    {
        Job,
        Setup,
        Scan,
        SPC
    }
}
