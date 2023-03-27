using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System.Collections.Generic;
using Toss.Core.Models;
using Toss.Core.Names;

namespace Toss.Main.Local.ViewModels
{
    public partial class MyAssetContentViewModel : ObservableBase, IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        [ObservableProperty]
        private List<AssetModel> assets;

        [ObservableProperty]
        private AssetModel asset;

        [ObservableProperty]
        private string menu;
        public MyAssetContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            Assets = new List<AssetModel>()
            {
                new AssetModel("IBK기업은행","1,912,152원"),
                new AssetModel("IBK기업은행(나라사랑통장)","2,616,322원"),
                new AssetModel("국민은행","1,234,567원"),
                new AssetModel("국민은행","1,234,567원"),
            };
            Menu = "자산";
        }
        public void OnLoaded(IViewable smartWindow)
        {

        }
    }
}
