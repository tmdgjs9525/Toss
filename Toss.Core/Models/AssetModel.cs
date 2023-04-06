using Toss.Core.Enums;

namespace Toss.Core.Models
{
    public class AssetModel
    {
        
        public string AssetName { get; set; }
        public string Money { get; set; }
        public string BankType { get; set; }
   

        public AssetModel(string AssetName, string Money, string BankType)
        {
            this.AssetName = AssetName;
            this.Money = Money;
            this.BankType = BankType;
        }
    }
}
