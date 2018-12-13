using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataBindingDemo
{
    class FaktorKonverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int wert = System.Convert.ToInt32(value);
            int faktor = System.Convert.ToInt32((parameter as Entry).Text);
            wert *= faktor;
            return wert;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
