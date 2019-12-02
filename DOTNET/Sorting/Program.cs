using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main()
        {
            int[] a = { 12, 23, 1, 4, 90, 23, 11, 22, 67, 93, 100, 24, 13, 12, 46, 16, 89, 13, 34, 29 };
            int[] result;
            bool sorted = false;
            Console.WriteLine("Before applying the sort operation");
            foreach (int i in a)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            //this is how your menu driven program shold work.

            bool loop = false; //this variable tells whether to loop again or not
            bool parsed =false; //this variable tells whether to conversion of user input to desired data type was successfull
            int algo_choice; //this variable tells if the conversion was successfull, is the value supplied by user is permitted in program logic.
           
            do //bst for menu driven programs
            {
                Console.WriteLine();

                Console.WriteLine("Press 1 for Bubble Sort");
                Console.WriteLine("Press 2 for Quick Sort");
                Console.WriteLine("Press 0 to exit");
                parsed = int.TryParse(Console.ReadLine(), out algo_choice);

                if (parsed)
                    if (algo_choice >= 1 && algo_choice <= 9) {
                        Console.WriteLine("Good Input! you have selected the algorithm number {0}", algo_choice);
                        loop = false; }
                    else
                    {
                        Console.WriteLine("Bad Input! The Algorithm key {0} is not supported.", algo_choice);
                        loop = true;
                    }
                else
                {
                    Console.WriteLine("Invalid input! Please enter an integer value");
                    loop = true;
                }
                /*
                 
                switch statement will come here
             */
                switch (algo_choice)
                {
                    case 1:
                        result = SortingAlgos.BubbleSort(a, out sorted);

                        
                        break;
                    default:
                        result =new int[1];
                        sorted = false;
                        Console.WriteLine("The requested key {0} is not implemented yet", algo_choice);
                        break;
                }
                if (sorted)
                {
                    Console.WriteLine("Below is the sorted Array");
                    foreach (int i in result)
                    {
                        Console.Write("{0} ", i);
                    }

                    Console.WriteLine();

                    loop = false;
                    parsed = false;
                    int endProgram = 0;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Would you like to continue");
                        Console.WriteLine("Press 1 if No");
                        Console.WriteLine("Press 0 if Yes");
                        parsed = int.TryParse(Console.ReadLine(), out endProgram);
                        if (parsed)
                            if (endProgram == 1)
                                loop = false;
                            else
                                loop = true;
                        else
                        {
                            Console.WriteLine("Invalid Input! Please enter 1 for Yes and 0 for No");
                            loop = true;
                        }
                    } while (loop);
                }
            } while(loop);
            
            //Console.ReadKey();
        }
    }
}
