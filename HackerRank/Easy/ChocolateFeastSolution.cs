
namespace HackerRank.Easy
{
    public class ChocolateFeastSolution
    {
        public int[] Outputs { get; private set; }

        public ChocolateFeastSolution(string[] inputs)
        {
            Outputs = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                string[] line = inputs[i].Split(null);
                int n = int.Parse(line[0]);
                int c = int.Parse(line[1]);
                int w = int.Parse(line[2]);

                Outputs[i] = DetermineChocalates(n, c, w);
            }
        }

        static int DetermineChocalates(int n, int c, int w)
        {
            int chocalates = n / c;
            int wrappers = chocalates;

            while (wrappers >= w)
            {
                int free = wrappers / w;
                chocalates += free;
                wrappers = wrappers - (w * free) + free;
            }

            return chocalates;
        }
    }

}

