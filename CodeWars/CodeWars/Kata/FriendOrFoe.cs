using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class FriendOrFoe
    {
        public static IEnumerable<string> FriendOrFoeMethod(string[] names)
        {
            return names.Where(i => i.Length == 4).ToList();
        }
    }
}
