using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class StringSummer
    {
        public static string SumStrings(object stringA, object stringB)
        {
            BigInteger a = stringA == string.Empty ? 0 : BigInteger.Parse(stringA.ToString());
            BigInteger b = stringB == string.Empty ? 0 : BigInteger.Parse(stringB.ToString());
            return (a + b).ToString();
        }
    }
}
