﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaviSharp;

namespace LXIntegratedNavigation.WPF.Converters;

public class VectorToStringConverter : BaseConverter<VectorToStringConverter>
{
    #region Public Methods

    public override object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is null)
            return string.Empty;
        return string.Join(',', (Vector)value);
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var str = value.ToString();
        if (string.IsNullOrEmpty(str))
        {
            return Vector.Empty;
        }
        return Vector.Parse(str);
    }

    #endregion Public Methods
}