using System.Linq;

namespace HackerRank.Easy
{
    public class FillingJarsSolution
    {
        public long Output { get; private set; }

        public FillingJarsSolution(string[] inputs)
        {
            int n_jars = int.Parse(inputs[0]);

            long[] jars = new long[n_jars];
            long total = 0;
            for (int i = 1; i < inputs.Length; i++)
            {
                int[] m = inputs[i].Split(null).Select(x => int.Parse(x)).ToArray();
                int a = m[0] - 1;
                int b = m[1] - 1;
                int k = m[2];

                total += (b - a + 1) * k;

            }

            Output = total / (long)n_jars;
        }
    }
}