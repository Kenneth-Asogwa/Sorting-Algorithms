using System;

namespace InsertionSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int[] array = new int[5] { 3, 2, 7, 10, 8 };
            Console.WriteLine("Unsorted values: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            InsertionSort(array);
            Console.WriteLine("The sorted values: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" " + array[i]);
            }
            // Stop timing
            watch.Stop();
            Console.WriteLine("Time elapsed: {0}", watch.Elapsed);
            Console.Read();         
        }
        static void InsertionSort(int[] array)
         {
            int j;
            int key;
            for(int i = 0; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
         }


    }
}
