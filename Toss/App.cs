using Jamesnet.Wpf.Controls;
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
using Toss.Forms;
using Toss.Forms.UI.Views;

namespace Toss
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow();
        }
       
    }
}
