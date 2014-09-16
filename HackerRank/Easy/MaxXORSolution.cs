using System;

namespace HackerRank.Easy
{
    public class MaxXORSolution
    {
        public string Output { get; private set; }

        public MaxXORSolution(string[] inputs)
        {
            int l = Convert.ToInt32(inputs[0]);
            int r = Convert.ToInt32(inputs[1]);
            Output = maxXor(l, r).ToString();
        }

        static int maxXor(int l, int r)
        {
            byte _l = (byte)l;
            byte _r = (byte)r;
            //byte x = ~(_r);
            int b = ~(r | 0);
            return 0;
        }

    }

}
