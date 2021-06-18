using System;

namespace LayoutBase
{
    public interface ILayoutGenerator<TUI> where TUI:new()
    {
        TUI GetWindow();
    }
}
