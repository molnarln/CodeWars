using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CodeWars
{
    public static class IPv4Converter
    {
        public static string ConvertToIPv4(uint input)
        {
            if (input == 0)
            {
                return "0" + "." + "0" + "." + "0" + "." + "0";
            }
            string binary = Convert.ToString(input, 2);
            while (binary.Length < 32)
            {
                binary = "0" + binary;
            }
            string firstSection = Convert.ToUInt32(binary.Substring(0, 8), 2).ToString();
            string secondSection = Convert.ToUInt32(binary.Substring(8, 8), 2).ToString();
            string thirdSection = Convert.ToUInt32(binary.Substring(16, 8), 2).ToString();
            string fourthSection = Convert.ToUInt32(binary.Substring(24, 8), 2).ToString();
            return firstSection + "." + secondSection + "." + thirdSection + "." + fourthSection;
        }
    }
}
