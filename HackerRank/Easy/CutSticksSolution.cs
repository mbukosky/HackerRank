using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Easy
{
    public class CutSticksSolution
    {
        public List<string> Output { get; private set; }

        public CutSticksSolution(string input)
        {
            Output = new List<string>();

            int[] sticks = input.Split(null).Select(x => int.Parse(x)).ToArray();

            Array.Sort(sticks);

            Cut(sticks, (x) => Output.Add(x.ToString()));
        }

        static void Cut(int[] arr, Action<int> getSize)
        {
            //log interation
            if(arr.Length != 0)
                getSize(arr.Length);

            if (arr.Length < 2)
            {
                return;
            }            

            int smallest = arr[0];
            var after_cuts = arr.Select(x => x - smallest).Where(x => x > 0).ToArray();

            Cut(after_cuts, getSize);
        }
    }
}
