using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Easy
{
    public class GemStonesSolution
    {
        public string Output { get; private set; }

        public GemStonesSolution(string[] inputs)
        {
            Dictionary<char, int> gem_bucket = new Dictionary<char, int>();
            foreach (var rock in inputs)
            {
                foreach (var element in rock.Distinct())
                {
                    if (gem_bucket.ContainsKey(element))
                        gem_bucket[element] += 1;
                    else
                        gem_bucket.Add(element, 1);
                }
            }

            int gems = gem_bucket.Where(kvp => kvp.Value == inputs.Length).Count();

            Output = gems.ToString();
        }
    }
}
