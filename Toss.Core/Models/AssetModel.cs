using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss.Core.Models
{
    public class AssetModel
    {
        
        public string AssetName { get; set; }
        public string Money { get; set; }
        public AssetModel(string AssetName, string Money)
        {
            this.AssetName = AssetName;
            this.Money = Money;
        }
    }
}
