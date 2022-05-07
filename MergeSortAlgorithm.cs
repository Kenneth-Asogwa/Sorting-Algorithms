using System;

namespace MergeSortAlgorithm
{
    class Program
    {
        // Merge sort algorithm is based on divide and conquer strategy.
        // It works by recursively dividing the array into two equal halves, then sort them and combine them
        // sorting is done through recursion

        public static void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;        // divide the current array in 2 subarrays.
                MergeSort(arr, start, middle);        // sort the first part of array.
                MergeSort(arr, middle + 1, end);      // sort the second part of array.             
                Merge(arr, start, middle, end); // merge the subarrays by comparing elements in them.
            }
        }

        static  void Merge(int[] arr, int start, int middle, int end)
        {
            int p = start;
            int q = middle + 1;
            int[] tempArr = new int[end - start + 1];
            int k = 0;

            for(int i = start; i <= end; i++)
            {
                if (p > middle)					 //checks if first part comes to an end or not .
                    tempArr[k++] = arr[q++];

                else if (q > end)				//checks if second part comes to an end or not
                    tempArr[k++] = arr[p++];

                else if (arr[p] < arr[q])		//compare elements from both parts.
                    tempArr[k++] = arr[p++];

                else
                    tempArr[k++] = arr[q++];
            }

            for (int j = 0; j < k; j++)
            {
               arr[start++] = tempArr[j]; //Now the original array has elements in sorted manner including both parts.
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Size of Array: ");
            int n = int.Parse(Console.ReadLine());  
            
            int[] arr = new int[n];
            Console.WriteLine("Enter the corresponding values of the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(arr, 0, n - 1);
            Console.WriteLine("The sorted array after applying Merge Sort ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " "); //Print the sorted array to console.
            }
            Console.WriteLine();
            Console.Read();

        }
    }
}
