using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirovka_Sliyaniem
{
    public class MySort
    {
        public static int[] sort(int[] arr)
        {
            if (arr.Length == 1)
                return arr;

            int mid_point = arr.Length / 2;

            return merge(sort(arr.Take(mid_point).ToArray()), sort(arr.Skip(mid_point).ToArray()));
        }

        public static int[] merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];

            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }

            return merged;
        }
    }
}
