﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Web.Mvc.Converter
{
    public class Int32Converter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, Globalization.CultureInfo culture, object value)
        {            
            return Int32.Parse((string)value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, Globalization.CultureInfo culture, object value, Type destinationType)
        {
            return ((int)value).ToString();
        }
    }
}
