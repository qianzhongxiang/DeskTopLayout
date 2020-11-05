using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MiddleLayout_Semiconductor.ViewModels
{
    public class MainViewerViewModel : BindableBase
    {

        DelegateCommand<object> NavigateCommand;
        IRegionManager RegionManager;
        public MainViewerViewModel(IRegionManager regionManager)
        {
            NavigateCommand = new DelegateCommand<object>(Navigate);
            RegionManager = regionManager;
        }

        private void Navigate(object sender)
        {
            if (sender is Button)
            {
                RegionManager.RequestNavigate("MainView_M", (sender as Button).Name);
            }
        }

    }
}
