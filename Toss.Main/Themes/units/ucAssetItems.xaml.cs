using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Toss.Main.Themes.uc
{
    /// <summary>
    /// ucAssetItems.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ucAssetItems : JamesContent
    {
        public ucAssetItems()
        {
            InitializeComponent();
        }



        public string assetName
        {
            get { return (string)GetValue(assetNameProperty); }
            set { SetValue(assetNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty assetNameProperty =
            DependencyProperty.Register("assetName", typeof(string), typeof(ucAssetItems), new PropertyMetadata(string.Empty));



        public string money
        {
            get { return (string)GetValue(moneyProperty); }
            set { SetValue(moneyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty moneyProperty =
            DependencyProperty.Register("money", typeof(string), typeof(ucAssetItems), new PropertyMetadata(string.Empty));



    }
}
