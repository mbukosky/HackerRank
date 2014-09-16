using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Sorting
{
    public class QuickSortSolution
    {
        public List<string> Output { get; private set; }

        public QuickSortSolution(int[] ar)
        {
            Output = new List<string>();

            //ar = QuickSort(ar).ToArray();
            quickSort(ar.ToList());
        }

        //void quickSort(int[] ar)
        //{
        //    quickSort(ar, 0, ar.Length - 1);
        //}

        List<int> quickSort(List<int> arr)
        {
            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            if (arr.Count < 2)
                return arr;

            int pivot = 0;
            int pivot_val = arr[pivot];
            arr.RemoveAt(pivot);

            foreach (int i in arr)
            {
                if (i <= pivot_val)
                    less.Add(i);
                else if (i > pivot_val)
                    greater.Add(i);
            }

            List<int> resultSet = new List<int>(quickSort(less));
            if (less.Count == 0)
                less.Add(pivot_val);
            else
                greater.Add(pivot_val);

            resultSet.AddRange(quickSort(greater));

            Output.Add(string.Join(" ", resultSet));

            return resultSet; 
        }

        //void quickSort(List<int> arr)
        //{
        //    List<int> less = new List<int>();
        //    List<int> equal = new List<int>();
        //    List<int> greater = new List<int>();

        //    if (arr.Count > 1)
        //    {
        //        int pivot_val = arr[0];
        //        foreach (int x in arr)
        //        {
        //            if (x < pivot_val)
        //                less.Add(x);
        //            if (x == pivot_val)
        //                equal.Add(x);
        //            if (x > pivot_val)
        //                greater.Add(x);
        //        }

        //        quickSort(less);
        //        quickSort(greater);

        //        arr = less.Concat(equal).Concat(greater).ToList();

        //        Output.Add(string.Join(" ", arr));
        //    }
        //}

        public IEnumerable<int> QuickSort(IEnumerable<int> arr)
        {
            if (arr.Count() < 2)
                return arr;

            int pivot = arr.First();

            Output.Add(string.Join(" ", arr));

            return QuickSort(arr.Where(x => x < pivot))
                .Concat(new int[] { pivot })
                .Concat(QuickSort(arr.Where(x => x > pivot)));
        }

        void quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = InPlacePartition(arr, left, right);

                quickSort(arr, left, pivot - 1);
                quickSort(arr, pivot + 1, right);

                Output.Add(string.Join(" ", arr.Skip(left).Take(right - left)));
            }
        }

        int InPlacePartition(int[] ar, int left, int right)
        {
            int pivot_idx = Pivot(left, right);
            int pivot_val = ar[pivot_idx];

            Swap(ar, pivot_idx, right);

            int store_idx = left;
            for (int i = left; i < right; i++)
            {
                if (ar[i] < pivot_val)
                {
                    Swap(ar, i, store_idx);
                    store_idx++;
                }
            }

            Swap(ar, store_idx, right);

            return store_idx;
        }

        int Pivot(int left, int right)
        {
            return left;
        }

        void Swap(int[] ar, int left, int right)
        {
            int temp = ar[left];
            ar[left] = ar[right];
            ar[right] = temp;
        }
    }
}
