using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayout_Semiconductor.Module
{
    class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("MainViewerRegion", typeof(MainViewer));
            region.RegisterViewWithRegion("MainControllerRegion", typeof(MainController));

            region.RegisterViewWithRegion("main_view",typeof(ViewItem<testui>));

            //region.RegisterViewWithRegion("main_view",typeof(ViewItem<testui>));
            //region.RegisterViewWithRegion("main_view",typeof(ViewItem<testui>));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
