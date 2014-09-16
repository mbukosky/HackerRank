using System;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    public class SherlockSolution
    {
        public string Output { get; private set; }

        public SherlockSolution(string input)
        {
            int n = int.Parse(input);

            Output = GetDecent(n).Aggregate(new StringBuilder(), (sb, x) => sb.Append(x), (sb) => sb.ToString());
        }

        static string GetDecent(int n)
        {
            if (n % 3 == 0)
            {
                return new String('5', n);
            }
            else
            {
                for (int i = n; i >= 0; i--)
                {
                    if (i % 3 == 0 && (n - i) % 5 == 0)
                    {
                        return new String('5', i) + new String('3', n - i);
                    }
                }
            }

            return "-1";
        }
    }
}
