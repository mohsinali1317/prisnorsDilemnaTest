using System;
using System.Collections.Generic;
using System.Text;

namespace PrisnorsDilemna
{
    public static class Helper
    {
        public static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }
    }
}
