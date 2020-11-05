using MiddleLayout_Semiconductor.Module;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MiddleLayout_Semiconductor
{
    public class BootStrapper : Prism.Unity.PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Views.MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanelEx),Container.Resolve<MainViewAdapter>());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<MainModule>();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">"main_view","sub_view","job_controller","setup_controller","scan_controller","spc_controller"</param>
        /// <param name="svgID"></param>
        public void RegisterView<T>(string str, string svgID) where T : UIElement
        {

        }


        public void RegisterTool(string str, string svgID,Action handler) 
        {

        }
    }
}
