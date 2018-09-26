using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirovka_Sliyaniem
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 111111, 11, 111, 11111, 1, 1111111, 0, 11111111, 111111111, 1111 };
            //For tests
            int length = 100;
            int[] arr = new int[length];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(1, 100);
            //For tests
            DateTime t = DateTime.Now;
            Console.WriteLine(string.Join(" ", MySort.sort(arr)));
            Console.WriteLine("\n\nTimer: {0}", DateTime.Now - t);
            Console.ReadKey();
        }  
    }
}
