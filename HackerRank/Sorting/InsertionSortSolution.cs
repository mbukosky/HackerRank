using System;
using System.Linq;

namespace HackerRank.Sorting
{
    public class InsertionSortSolution
    {
        public InsertionSortSolution(string input)
        {
            //int[] ar = new int[] { 2, 4, 6, 8, 3 };
            int[] ar = new int[] { 2 };

            string foo = "";
            var xcvc = foo.Split(',');

            //Enumerable.Concat()

            int v = ar[ar.Length - 1];
            int i = ar.Length - 1;
            while (i > 0)
            {
                if (ar[i - 1] > v)
                {
                    ar[i] = ar[i - 1];
                }
                else
                {
                    ar[i] = v;
                    Console.WriteLine(string.Join(" ", ar));
                    break;
                }
                i--;

                Console.WriteLine(string.Join(" ", ar));
            }

            //for (int i = ar.Length; i < length; i++)
            //{

            //}

            //for(int i = ar.Length - 2; i )

            //    //ar[j - 1] = ar[j];       
            //}


        }
    }
}
