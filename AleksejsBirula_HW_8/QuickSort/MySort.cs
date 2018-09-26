using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class MySort
    {
        public static void Sort(int[] arr, int l, int r)
        {
            int i = l;
            int j = r;
            int x = arr[(l + r) / 2];

            while (i <= j)
            {
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (l < j) Sort(arr, l, j);
            if (i < r) Sort(arr, i, r);
        }
    }
}
