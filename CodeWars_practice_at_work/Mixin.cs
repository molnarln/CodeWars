using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public interface IColor
    {
        byte Red { get; }
        byte Green { get; }
        byte Blue { get; }
    }

    public static class ColorExtensions
    {
        public static byte Luminance(this IColor c)
        {
            return (byte)(c.Red * 0.3 + c.Green * 0.59 + c.Blue * 0.11);
        }
        
    }
    public class Color : IColor
    {
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        public Color(byte Red, byte Green, byte Blue)
        {
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
        }
    }
}
