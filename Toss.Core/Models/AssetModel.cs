namespace Toss.Core.Models
{
    public class AssetModel
    {
        
        public string AssetName { get; set; }
        public string Money { get; set; }
        public string ImageSource { get; set; }
        public AssetModel(string AssetName, string Money, string ImageSource)
        {
            this.AssetName = AssetName;
            this.Money = Money;
            this.ImageSource = ImageSource;
        }
    }
}
