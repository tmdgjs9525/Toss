using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Toss.Core.Enums;

namespace Toss.Core.Converter
{
    public class BankImageConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagepath = @"/Toss.Main;component/Resources/";
            string banks = value.ToString();
            switch (banks)
            {
                case "KB": return imagepath+ "KBCircleImage.png";
                case "IBK": return imagepath + "IBKCircleImage.png";
                case "Kakao": return imagepath + "KaKaoCircleImage.png";
                case "Toss" : return imagepath + "TossCircleImage.png";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
