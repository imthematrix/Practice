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
                //the limits may be n-1 or n, it doesn't matter
            {
                for(int j =0; j<a.Length-1; j++) //the limit here should be n-1, otherwise index out of bound exception will happen
                {
                    if (a[j] > a[j+1]) //only adjacent elements are compared
                        SwapElements(ref a[j], ref a[j+1]);
                }
            }

            sorted = true;
            return a;
        }

        //actual implementation of quick sort
        static void QS(int[] x, int l, int h)
        {
            
            if (l < h)
            {
                int partition_element_index=Partition(x, l, h);

                QS(x, l, partition_element_index);
                QS(x, partition_element_index + 1, h);
            }
        }
        //implementation of quick sort partition method
        static int Partition(int[] x, int l, int h)
        {
            int pivot = x[l];
            int i = l;
            int j = h;
            while (i < j)
            {
                do
                {
                    i++;
                } while (x[i] <= pivot && i<=h);
                do
                {
                    j--;
                } while (x[j] > pivot);
                if (i < j)
                {
                    SwapElements(ref x[i], ref x[j]);
                }
            }
            SwapElements(ref x[l], ref x[j]);
            return j;
        }
        public static int[] QuickSort(int[] a, out bool sorted)
        {
            
            Console.WriteLine("\nPerforming Quick Sort\n");
            int low = 0;
            int high = a.Length - 1;

            QS(a, low, high);

            sorted = true;
            return a;
        }

    }
}
