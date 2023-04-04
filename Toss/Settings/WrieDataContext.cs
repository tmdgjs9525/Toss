using Jamesnet.Wpf.Global.Location;
using Toss.Forms;
using Toss.Forms.UI.Views;
using Toss.Forms.ViewModels;
using Toss.Main.Local.ViewModels;
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
