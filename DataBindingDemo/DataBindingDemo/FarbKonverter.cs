using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace DataBindingDemo
{
    class Farbkonverter : IValueConverter
    {
        FieldInfo[] fields = typeof(Color).GetFields();
        Dictionary<string, string> localizedColors = new Dictionary<string, string>
        {
            {"Blau","Blue" },
            {"Rot","Red" },
            {"Gelb","Yellow" }
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            FieldInfo targetColor;
            if (localizedColors.ContainsKey(value.ToString()))
                targetColor = fields.FirstOrDefault(x => x.Name == localizedColors[value.ToString()]);
            else
                targetColor = fields.FirstOrDefault(x => x.Name == value.ToString());

            if (value.ToString().StartsWith("#"))
                return Color.FromHex(value.ToString());
            if (targetColor == null)
                return Color.Black;
            else
            {
                return targetColor.GetValue(typeof(Color));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
