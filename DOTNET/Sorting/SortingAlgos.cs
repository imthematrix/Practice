using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Sorting
{
    class SortingAlgos
    {
        //supply an array of length 20 with random variables
        public static int[] GetArray(int limit)
        {
            //int limit = 25;
            Random r = new Random();
            int[] arr = new int[limit];
            for(int i =0; i<limit; i++)
            {
                arr[i] = r.Next(1, 1000);
            }
            return arr;
        }
        
        static void SwapElements(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int[] BubbleSort(int[] a, out bool sorted)
        {
            Console.WriteLine("\nPerforming Bubble Sort\n");
            /*
             * the basic idea behind bubble sort is that, the largest elment has to come out on the top after each iteration
             * So, the first loop will go from 0 to n-1
             *  meanwhile the internal loop goes from 0 to n-i-2, i.e. n-1 -i-1
             *  this makes sure that the last element is in i and j gets the second last element
             *  => n-1 last, n-2 second last
             */

            for(int i = 0; i<a.Length; i++)
            {
                for(int j =i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                        SwapElements(ref a[i], ref a[j]);
                }
            }

            sorted = true;
            return a;
        }

        public static int[] QuickSort(int[] a, out bool sorted)
        {
            
            Console.WriteLine("\nPerforming Quick Sort\n");
            int[] result;
            result = a;
            sorted = true;
            return result;
        }

    }
}
