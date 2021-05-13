using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Delayer
    {
        public async Task<string> DelayFunction()
        {
            await Task.Delay(5000);
            return "delayed";
        }

    }
}
