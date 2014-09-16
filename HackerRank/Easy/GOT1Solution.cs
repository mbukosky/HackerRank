using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Easy
{
    public class GOT1Solution
    {
        public string Output { get; private set; }

        public GOT1Solution(string input)
        {
            Dictionary<char, int> bucket = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (bucket.ContainsKey(c))
                    bucket[c] += 1;
                else
                    bucket.Add(c, 1);
            }

            int odds = bucket.Values.Count(x => x % 2 != 0);

            Output = (odds > 1) ? "NO" : "YES";
        }

    }

}
