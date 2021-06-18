using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutBase
{
    public abstract class ModuleBase
    {
        public readonly Guid ID = Guid.NewGuid();

        public ModuleBase(LyType lyType)
        {
            this.LyType = lyType;

            ModuleMap.Instance.Add(this.ID,new WeakReference(this));
        }
        /// <summary>
        /// RealModule can be null
        /// </summary>
        public readonly LyType LyType;

        internal protected abstract void Register(RegionManager regionManager);
        internal protected abstract void OnInitialized();
    }


    public class RegionManager {
        public void Add(string regionName,Type viewType)
        { 
            
        }
    }


    internal class ModuleShirl : Prism.Modularity.IModule
    {
        internal Prism.Modularity.IModule RealModule => ModuleMap.Instance[this.ID].Target as Prism.Modularity.IModule;
        public void OnInitialized(IContainerProvider containerProvider)
        {
            throw new NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
