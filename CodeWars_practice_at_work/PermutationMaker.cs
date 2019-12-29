using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class PermutationMaker
    {
        //--------------------------NEED TO FINISH!!!!!----------------------------
        public static List<string> CreatePermutations(string input)
        {
            input.ToCharArray().ToList().ForEach(c => c.ToString());
            var permutations = GetPermutations(Enumerable.Range(0, input.Length), input.Length)
                .Select(t => t.Select(i => input[i]));
            List<string> output = new List<string>();
            permutations.ToList().ForEach(i => Enumerable.Cast<char[]>(i));

            foreach (var item in permutations)
            {
                output.Add(new string(item.ToList().ToArray()));
            }
            return output;
        }

        public static IEnumerable<IEnumerable<T>>
            GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                    .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}