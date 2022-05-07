using System;

namespace BinarySearchAlgorithm
{
    public class BinarySearch
    {
        public int Binary_Search(int[] data, int itemToSearch)
        {
            //initialize the start and the end value
            int start = 0;
            int end = data.Length - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (data[middle] == itemToSearch)
                {
                    return middle;

                }
                else if (data[middle] < itemToSearch)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }

            }
            return -1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            int[] data = { 68, 6, 12, 18, 36, 71 };
            BinarySearch result = new BinarySearch();
            int itemToSearch = 36;
            int index = result.Binary_Search(data, itemToSearch);
            Console.WriteLine((index > 0) ? $"Item {itemToSearch} found at position {index}" : $"Item {itemToSearch} not found");

            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

        }
    }
}
