using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toss.Settings;

namespace Toss
{
    internal class Stater
    {
        [STAThread]
        public static void Main()
        {
            _ = new App()
                .AddInversionModule<ViewModules>()
                .AddInversionModule<DirectModules>()
                .AddWireDataContext<WrieDataContext>()
                .Run();
        }
    }
}
