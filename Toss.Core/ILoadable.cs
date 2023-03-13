using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss.Core
{
    public interface ILoadable
    {
        void OnLoaded(PrismContent view);
    }
}
