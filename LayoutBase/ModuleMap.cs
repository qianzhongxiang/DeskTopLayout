using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutBase
{
    internal class ModuleMap : Dictionary<Guid, WeakReference>
    {
        private static ModuleMap _Instance;
        internal static ModuleMap Instance => _Instance ?? (_Instance=new ModuleMap());
    }
}
