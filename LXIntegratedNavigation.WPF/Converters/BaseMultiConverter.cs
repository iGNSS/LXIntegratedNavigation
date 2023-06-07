﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LXIntegratedNavigation.WPF.Converters;

public abstract class BaseMultiConverter<T> : IMultiValueConverter where T : class, new()
{
    public T Instance { get; } = new();

    public abstract object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
    public abstract object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
}
