using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Vitri.Converter
{
    //CLASS này dùng đề chức năng đổi màu cho các thuộc tính đã Binding.
    class BooleanToBrushesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = value as bool?;
            if (state == null)
                return Brushes.Gray;

            if (state == true)
                return Brushes.SteelBlue;

            return Brushes.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
