using System;

namespace Example
{
    public class DateParser
    {
        public int GetYearFromDateTime(string dateTimmeFromString)
        {
            var dt = DateTime.Parse(dateTimmeFromString);
            return dt.Year;
        }
        public int GetYearFromDateTimeFromSplit(string dateTimmeFromString)
        {
            var dt = dateTimmeFromString.Split('-');
            return int.Parse(dt[0]);
        }
        public int GetYearFromDateTimeFromIndex(string dateTimmeFromString)
        {
            var index = dateTimmeFromString.IndexOf('-');
            return int.Parse(dateTimmeFromString.Substring(0, index));
        }
        public int GetYearFromDateTimeFromSpan(ReadOnlySpan<char> dateTimmeFromspan)
        {
            var index = dateTimmeFromspan.IndexOf('-');
            return int.Parse(dateTimmeFromspan.Slice(0, index));
        }
    }
}
