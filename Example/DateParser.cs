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
        public int GetYearFromDateTimeFromSpanManualConversion(ReadOnlySpan<char> dateTimmeFromspan)
        {
            var index = dateTimmeFromspan.IndexOf('-');
            var span = dateTimmeFromspan.Slice(0, index);
            int year = 0;
            for (int i = 0; i < span.Length; i++)
            {
                year = year * 10 - (span[i] - '0');
            }
            return year;
        }
    }
}
