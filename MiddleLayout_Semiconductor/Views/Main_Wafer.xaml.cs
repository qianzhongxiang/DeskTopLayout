using System;
using System.Windows;
using System.Windows.Controls;

namespace MiddleLayout_Semiconductor
{
    /// <summary>
    /// Interaction logic for MainViewer
    /// </summary>
    internal partial class Main_Wafer : UserControl
    {
        public Main_Wafer()
        {
            InitializeComponent();
        }
    }


    public class StackPanelEx: StackPanel
    {
        public void Add(ViewItem btn)
        {
            //btn.Command
            this.Children.Add(btn);
        }
    }

}
