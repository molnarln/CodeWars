using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Isogram
    {

        public static bool IsogramMethod(string str)
        {
            if (str != "")
            {
                var frequency = str.ToLower().ToCharArray().GroupBy(i => i).Select(i => i.Count()).ToList();
                if (frequency.Max() > 1)
                {
                    return false;
                }
            }

            if (str == "")
            {
                return true;
            }
            return true;
        }
    }
}
