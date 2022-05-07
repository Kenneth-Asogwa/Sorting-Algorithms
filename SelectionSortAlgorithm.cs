using System;

namespace SelectionSortAlgorithm
{
    class SelectionSortAlgorithm
    {
        static void SelectionSort(int[] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < data.Length; j++)
                {
                    if(data[j] < data[min])
                    {
                        min = j;
                    }
                }
                int temp = data[i];
                data[i] = data[min];
                data[min] = temp;

            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            // Create the array
            int[] arr = new int[n];

            Console.WriteLine("Enter the corresponding values of the array");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(DateTime.Now);
            // sort  the array
            SelectionSort(arr);
            // print the sorted array
            Console.WriteLine("Sorted array");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" " + arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            Console.Read();

            
        }
    }
}
