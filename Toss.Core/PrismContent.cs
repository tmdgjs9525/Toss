using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Toss.Core
{
    public class PrismContent : ContentControl
    {
        public PrismContent()
        {
            ViewModelLocationProvider.AutoWireViewModelChanged(this, AutoWireViewModelChanged);
            Loaded += PrismContent_Loaded;
        }

        private void PrismContent_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ILoadable loadable)
            {
                loadable.OnLoaded(this);
            }
        }

        private void AutoWireViewModelChanged(object arg1, object arg2)
        {
            if (arg1 is FrameworkElement fe)
            {
                fe.DataContext = arg2;
            }
        }
    }
}
