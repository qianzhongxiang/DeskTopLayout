using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MiddleLayout_Semiconductor
{
    class MainViewAdapter : RegionAdapterBase<StackPanelEx>
    {
        public MainViewAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, StackPanelEx regionTarget)
        {
            
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach (var item in e.NewItems)
                    {
                        if (item is ViewItem)
                        {
                            var ii = item as ViewItem;
                            ii.Register(region.RegionManager);
                            regionTarget.Add(ii);
                        }
                    }
                }
                else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {

                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }


    public class ViewItem : Button
    {
        Type _Type;
        IRegionManager _RegionManager;
        public ViewItem(Type type)
        {
            _Type = type;
            Height = 60;
            //Name = "View_" + DateTime.Now.ToString("yyyyMMddHHmmsssss").ToString();
        }

        public void Register(IRegionManager region)
        {
            _RegionManager = region;
        }
        public string Svg
        {
            set
            {
                this.Content = "";
            }
        }
        protected override void OnClick()
        {
            base.OnClick();
            var mm = _RegionManager.Regions["MainView_M"];
            if (mm is null) { return; }
            else
            {
                mm.RemoveAll();
                mm.Add(View);
            }
        }
        private UIElement _View;
        public UIElement View { get => _View ?? (_View = Activator.CreateInstance(_Type) as UIElement); }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"> the constructor of T cannot has any parameters</typeparam>
    public class ViewItem<T> : ViewItem
    {
        public ViewItem() : base(typeof(T))
        {

        }
    }
}
