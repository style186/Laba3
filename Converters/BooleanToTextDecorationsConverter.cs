﻿using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace LABA3.Converters
{
    public class BooleanToTextDecorationsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isCompleted)
            {
                // Пример использования параметра
                if (parameter is string str && str == "ApplyStrikethrough")
                {
                    return isCompleted ? TextDecorations.Strikethrough : null;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


