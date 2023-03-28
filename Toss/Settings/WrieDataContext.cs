using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toss.Forms;
using Toss.Forms.UI.Views;
using Toss.Forms.ViewModels;
using Toss.Main.Local.ViewModels;
using Toss.Main.Themes.uc;
using Toss.Main.UI.Views;

namespace Toss.Settings
{
    internal class WrieDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainWindow, MainWindowViewModel>();
            items.Register<MainContent,MainContentViewModel>();
            items.Register<MyAssetContent, MyAssetContentViewModel>();
            //items.Register<ucAssetItems, ucAssetItemsViewModel>();
        }
    }
}
