using System;
using System.Linq;

namespace HackerRank.Easy
{
    public class AngryChildrenSolution
    {
        public int Output { get; private set; }

        public AngryChildrenSolution(string[] inputs)
        {
            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);

            int[] arr = new int[n];
            int j = 0;
            foreach (var val in inputs[2].Split(null).Select(x => int.Parse(x)))
            {
                arr[j++] = val;
            }
            Array.Sort(arr);

            int unfairness = int.MaxValue;
            for (int i = 0; i < arr.Length - k; i++)
            {
                int temp = arr[i + k - 1] - arr[i];

                if (temp < unfairness)
                    unfairness = temp;
            }

            Output = (int)unfairness;
        }
    }
}
