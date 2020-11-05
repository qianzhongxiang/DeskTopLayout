using Prism.Ioc;
using Prism.Modularity;
using System.Windows.Controls;

namespace MiddleLayout_Semiconductor
{
    /// <summary>
    /// Interaction logic for MainController
    /// </summary>
    public partial class MainController : UserControl,IModule
    {
        public MainController()
        {
            InitializeComponent();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            throw new System.NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<>
            throw new System.NotImplementedException();
        }
    }
}
