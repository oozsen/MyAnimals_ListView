using System;
using System.Globalization;
using MyAnimals_ListView.Data;
using Xamarin.Forms;

namespace MyAnimals_ListView.Converters
{
    public class DifficultyToIndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Difficulty difficulty = (Difficulty)value;
            if (targetType != typeof(int))
                throw new Exception("DifficultyConverter.Convert expected integer targetType");
            return (int)difficulty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int index = (int)value;
            if (targetType != typeof(Difficulty))
                throw new Exception("DifficultyConverter.ConvertBack expected Gender targetType");
            return (Difficulty)index;
        }
    }
}
