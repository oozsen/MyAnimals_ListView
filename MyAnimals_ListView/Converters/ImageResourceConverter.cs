using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyAnimals_ListView.Converters
{
    public class ImageResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource("MyAnimals_ListView.Images." + (value ?? ""), typeof(ImageResourceConverter));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
