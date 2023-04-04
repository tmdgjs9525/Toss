using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Toss.Main.UI.units
{
    public class AssetItem : JamesContent
    {
        static AssetItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AssetItem), new FrameworkPropertyMetadata(typeof(AssetItem)));
        }

        public AssetItem()
        {

        }
    }
}
