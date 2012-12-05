using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccLib.Extensions
{
    public static class GenericExtensions
    {
        public static TValue Get<TItem, TValue>(this TItem item, Func<TItem, TValue> selector) where TItem : class
        {
            return item.Get(selector, default(TValue));
        }

        public static TValue Get<TItem, TValue>(this TItem item, Func<TItem, TValue> selector, TValue defaultValue) where TItem : class
        {
            return (item == null) ? defaultValue : selector(item);
        }
    }
}
