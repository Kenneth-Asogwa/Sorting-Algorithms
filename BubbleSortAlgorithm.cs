using System;

namespace BubbleSortAlgorithm
{
    class BubbleSortAlgorithm
    {
        static void BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] >  arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of your array: ");
            int n = int.Parse(Console.ReadLine());

            // Create an array of the given length
            int[] arr = new int[n];

            Console.WriteLine("Enter the corresponding values of the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Sort the array
            Console.WriteLine(DateTime.Now);
            BubbleSort(arr);
            // Print the sorted array
            Console.WriteLine("Sorted arrays");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            Console.Read();


            
        }
    }
}
