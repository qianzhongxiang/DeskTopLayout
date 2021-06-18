using System.Windows;

namespace MiddleLayout_Semiconductor
{
    public class LayoutGenerator : LayoutBase.ILayoutGenerator<System.Windows.Window>
    {
        public Window GetWindow()
        {
            return new Views.MainWindow();
        }
    }
}
