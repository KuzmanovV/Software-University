using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DateModifier
{
    public static class DateModifier
    {
public static int GetDiff(string startDateStr, string endDateStr)
        {
            DateTime startDate = DateTime.Parse(startDateStr);
            DateTime endDate = DateTime.Parse(endDateStr);

             TimeSpan diff = startDate-endDate;
            return Math.Abs(diff.Days);
        }
    }
}
