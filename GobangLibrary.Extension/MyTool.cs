using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GobangLibrary.Extension
{ 
    public static class Extension
    {
        public static bool ToPort(this string s, out int result)
        {
            try
            {
                result = Int32.Parse(s);
                if (result >= 0 && result <= 66532) return true;
                else                                return false;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }

        public static bool ToServerIP(this string s, out IPAddress result)
        {
            try
            {
                result = IPAddress.Parse(s);
                return true;
            }
            catch (Exception)
            {
                result = IPAddress.None;
                return false;
            }
        }
    }
}
