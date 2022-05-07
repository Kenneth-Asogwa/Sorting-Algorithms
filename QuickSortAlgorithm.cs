using System;
using System.Diagnostics;

namespace QuickSortAlgorithm
{
    class Program
    {
        //Generally at each step you choose an element called pivot and reorder the array into two sections: 
        //at the left side move all elements ≤ pivot and at the right side move all elements > pivot.
        //Finally run the quicksort algorithm recursively over the left and the right sides.
        static void Main(string[] args)
        {

            // Calculate the execution time of the algorithm
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int[] array = new int[5] { 34, 23, 56, 14, 57 };
            // Print the sorted array
            Console.WriteLine("Unsorted values: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted values: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            watch.Stop();
            Console.WriteLine("Time elapsed: {0}", watch.Elapsed);

            Console.Read();
        }
        static void QuickSort(int[] array, int left, int right)
        {
            int i;
            if(left < right)
            {
                i = Partition(array, left, right);
                QuickSort(array, left, i - 1);
                QuickSort(array, i + 1, right);
            }
        }
        static int Partition(int[] array, int left, int right)
        {
            int temp;
            int pivot = array[right];
            int i = left - 1;
            for(int j = left; j <= right - 1; j++)
            {
                if(array[j] <= pivot)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                   
                }
            }
            temp = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp;
            return i + 1;
            
        }
    }
}
