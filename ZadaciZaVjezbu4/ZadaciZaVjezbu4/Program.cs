using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 7, 5, 6, 9, 8, 3, 1, 4, 2};
            Sort.QuickSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            Console.ReadKey();
        }
    }
}
