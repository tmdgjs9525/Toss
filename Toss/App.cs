using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Toss.Core;
using Toss.Forms.UI.Views;

namespace Toss
{
    public class App : PrismApplication
    {
        private List<IModule> _modules;

        public App()
        {
            _modules = new();
        }
        protected override Window CreateShell()
        {
            return new MainWindow();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            // 추후작업
            foreach (IModule module in _modules)
            {
                moduleCatalog.AddModule(module.GetType());
            }
        }

        internal App AddModule<T>() where T : IModule, new()
        {
            IModule module = new T();
            _modules.Add(module);

            return this;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<PrismContent>(new MyAssetContent(), ContentName.MyAssetContent);
            containerRegistry.RegisterInstance<PrismContent>(new MainContent(), ContentName.MainContent);
        }
        internal App WireViewModel()
        {
            //ViewModelLocationProvider.Register<MainContent, MainContentViewModel>();
            return this;
        }
    }
}
