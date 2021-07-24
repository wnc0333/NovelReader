using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace NovelReader.Model
{
    /// <summary>
    /// 用于转换字体大小值的值转换器
    /// </summary>
    class FontSizeConverter : IValueConverter
    {
        //当值从绑定源传播给绑定目标时，调用方法Convert
        //四舍五入，将double转成int
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            int newValue= System.Convert.ToInt32(value);
            return newValue;
        }

        //当值从绑定目标传播给绑定源时，调用此方法ConvertBack
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            return (double)value;
        }
    }
}
