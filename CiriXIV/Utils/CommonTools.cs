using System;
using System.Collections.Generic;
using System.Text;

namespace CiriXIV.Utils
{
    public static class CommonTools
    {
        public static string getFormattedDate()
        {
            return DateTime.Now.ToString("MMMM dd, yyyy");
        }
    }
}
