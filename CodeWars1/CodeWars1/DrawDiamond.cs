using System.Text;

namespace CodeWars1
{
    class DrawDiamond
    {
        public static string PrintMethod(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }
            else
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < (n - 1) / 2 + 1; i++)
                {
                    for (int j = 0; j < ((n - 1) / 2) - (i * 1); j++)
                    {
                        str.Append(" ");
                    }
                    for (int j = 0; j < (i * 2) + 1; j++)
                    {
                        str.Append("*");
                    }
                    str.Append("\n");
                }
                for (int i = 0; i < (n - 1) / 2 + 1; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        str.Append(" ");
                    }
                    for (int j = 0; j < n - ((i + 1) * 2); j++)
                    {
                        str.Append("*");
                    }
                    str.Append("\n");
                }
                int len = str.ToString().Length;
                var newStr = str.ToString();
                var cslastIndex = newStr.LastIndexOf('*');
                var solution = newStr.Remove(cslastIndex + 2);
                return solution;
            }
        }
    }
}
