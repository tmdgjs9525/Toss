using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toss.Core;

namespace Toss.Settings
{
    internal class DirectModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MyAssetRegion", ContentName.MyAssetContent);
            regionManager.RegisterViewWithRegion("MainRegion", ContentName.MainContent);

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
