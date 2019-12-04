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
             * So, the first loop will go from 0 to n-1-1
             *  meanwhile the internal loop goes from 0 to n-1-1(to avoid exception), and it only checks the adjacent elements
             *  comparison is done only in j and j+1 elements
             */

            for(int i = 0; i<a.Length-1; i++)//notice the limits
            {
                for(int j =0; j<a.Length-1; j++)
                {
                    if (a[j] > a[j+1]) //only adjacent elements are compared
                        SwapElements(ref a[j], ref a[j+1]);
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
