using System.Collections.Generic;

namespace HackerRank
{
    public class NonReoccuringSolution
    {
        public string Output { get; private set; }

        public NonReoccuringSolution(string input)
        {
            Dictionary<char, int> bucket = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (bucket.ContainsKey(c))
                    bucket[c] = bucket[c] + 1;
                else
                    bucket.Add(c, 1);
            }

            foreach (var kvp in bucket)
            {
                if (kvp.Value == 1)
                {
                    Output = kvp.Key + "";
                    break;
                }
            }
        }
    }
}
