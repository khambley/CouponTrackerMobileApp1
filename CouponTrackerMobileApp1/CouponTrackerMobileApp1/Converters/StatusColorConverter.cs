using System;
using System.Globalization;
using Xamarin.Forms;

namespace CouponTrackerMobileApp1.Converters
{
    public class StatusColorConverter : IValueConverter
    {
        //This is a comment
        public StatusColorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? (Color)Application.Current.Resources["UsedColor"] : (Color)Application.Current.Resources["AvailableColor"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //used for controls that return data from plain text, like an Entry control.
            return null;
        }
    }
}
