﻿using Jamesnet.Wpf.Controls;
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
using Toss.Core;

namespace Toss.Forms.UI.Views
{
    public class MyAssetContent : JamesContent
    {
        static MyAssetContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyAssetContent), new FrameworkPropertyMetadata(typeof(MyAssetContent)));
        }
    }
}
