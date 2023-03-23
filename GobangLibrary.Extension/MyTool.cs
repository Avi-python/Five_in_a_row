using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GobangLibrary.Extension
{ 
    public static class Extension
    {
        public static bool toPort(this string s, out int result)
        {
            try
            {
                result = Int32.Parse(s);
                return true;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }
    }
}
