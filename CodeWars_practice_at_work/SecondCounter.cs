using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class SecondCounter
    {
        public static void CountSeconds(string args)
        {
            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args) : -1;
            while (max == -1 || counter < max)
            {
                counter++;
                Console.WriteLine($"Counter: {counter}");
                System.Threading.Tasks.Task.Delay(1000).Wait();
            }
        }
    }
}