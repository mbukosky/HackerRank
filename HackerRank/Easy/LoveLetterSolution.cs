using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    public class LoveLetterSolution
    {
        public string Output { get; private set; }

        public LoveLetterSolution(string input)
        {
            int operations = 0;
            for (int i = 0; i < input.Length / 2; i++)
            {
                int opposite_idx = input.Length - 1 - i;
                operations += Math.Abs(input[i] - input[opposite_idx]);
            }

            Output = operations.ToString();
        }
    }
}
