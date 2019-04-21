using System.Linq;

namespace CodeWars1
{
    class ValidParentheses
    {
        public static bool ValidParenthesesMain(string input)
        {

            var check = input.Where(i => i.Equals('(')).Count();
            var check2 = input.Where(i => i.Equals(')')).Count();

            if (input.Length >= 0 && input.Length <= 100)
            {
                if (input.Length > 0 && check == check2)
                {
                    return true;
                }
                if (input[0].Equals(')'))
                {
                    return false;
                }

                return check == check2 ? true : false;
            }
            return false;
        }
    }
}
