﻿using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;
using Toss.Core.Names;
using Toss.Forms.UI.Views;
using Toss.Main.UI.Views;

namespace Toss.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable,MainContent>(ContentNameManager.Main);
            containerRegistry.RegisterSingleton<IViewable, MyAssetContent>(ContentNameManager.MyAsset);        }
    }
}
