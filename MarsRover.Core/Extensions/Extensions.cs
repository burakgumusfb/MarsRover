using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Extensions
{
    public static class Extensions
    {
        public static int ToInt32(this string v)
        {
            return Convert.ToInt32(v);
        }
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
