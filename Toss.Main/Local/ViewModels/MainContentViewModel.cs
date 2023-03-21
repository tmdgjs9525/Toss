using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using Toss.Core.Names;

namespace Toss.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase , IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(IViewable smartWindow)
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
            IViewable myAssetContent = _containerProvider.Resolve<IViewable>(ContentNameManager.MyAsset);

            if (!mainRegion.Views.Contains(myAssetContent))
            {
                mainRegion.Add(myAssetContent);
            }
            mainRegion.Activate(myAssetContent);
        }
    }
}
