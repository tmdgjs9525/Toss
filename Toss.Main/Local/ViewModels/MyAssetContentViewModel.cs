using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using Toss.Core.Names;

namespace Toss.Main.Local.ViewModels
{
    public partial class MyAssetContentViewModel :ObservableBase,IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public MyAssetContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }
        public void OnLoaded(IViewable smartWindow)
        {
       
        }
    }
}
