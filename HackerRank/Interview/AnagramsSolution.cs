using System.Collections.Generic;

namespace HackerRank
{
    public class AnagramsSolution
    {
        public string Output { get; private set; }

        public AnagramsSolution(string[] inputs)
        {
            var x = BuildLookup(inputs[0]);
            var y = BuildLookup(inputs[1]);

            if (AreEqual(x, y))
                Output = "Anagrams!";
            else
                Output = "Not anagrams!";
        }

        private static bool AreEqual(Dictionary<char, int> x, Dictionary<char, int> y)
        {
            if (x.Count != y.Count)
                return false;

            foreach (var kvp in x)
            {
                if (!y.ContainsKey(kvp.Key) || y[kvp.Key] != kvp.Value)
                    return false;
            }

            return true;
        }

        private static Dictionary<char, int> BuildLookup(string input)
        {
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (lookup.ContainsKey(c))
                    lookup[c] = lookup[c] + 1;
                else
                    lookup.Add(c, 1);
            }

            return lookup;
        }
    }

}
