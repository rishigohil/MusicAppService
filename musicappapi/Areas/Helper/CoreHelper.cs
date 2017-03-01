using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppApi.Areas.Helper
{
    public static class CoreHelper
    {
        public static string GetDecade(short? year)
        {
            if (year >= 2000)
            {
                return string.Format("{0}'s", year.ToString());
            }
            else if(year >=1990 && year <= 1999)
            {
                return "90's";
            }
            else if (year >= 1980 && year <= 1989)
            {
                return "80's";
            }
            else if (year >= 1970 && year <= 1979)
            {
                return "70's";
            }
            else if (year >= 1960 && year <= 1969)
            {
                return "60's";
            }
            else if (year >= 1950 && year <= 1959)
            {
                return "50's";
            }
            else
            {
                return "Oldies";
            }
        }
    }
}