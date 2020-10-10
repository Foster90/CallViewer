using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Extensions
{
    public static class StringExtensions
    {
        public static string SubStringTo(this string thatString, int limit)
        {

            if (thatString.Length > limit)
            {
                return thatString.Substring(0, limit);
            }
            return thatString;

        }
    }
}
