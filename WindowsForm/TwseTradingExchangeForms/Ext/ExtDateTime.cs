using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwseTradingExchangeForms.Ext
{
    public static class ExtDateTime
    {
        public static DateTime ConvertToYmd(this DateTime value)
        {
            DateTime ret = new DateTime(value.Year, value.Month, value.Day);
            return ret;
        }
    }
}
