using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class PhoneNumberValidator
    {
        public static bool ValidatePhoneNumber(string input)
        {
            return Regex.Match(input, @"^\(\d{3}\)\s\d{3}-\d{4}$").Success ? true : false;
        }
    }
}