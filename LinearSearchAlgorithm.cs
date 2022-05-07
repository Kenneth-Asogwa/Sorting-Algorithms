using System;

namespace LinearSearchAlgorithm
{
    public class LinearSearch
    {

        public int Linear_Search(int[] data, int itemToFind)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == itemToFind)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] data = { 68, 6, 12, 18, 36, 71 };

            LinearSearch result1 = new LinearSearch();

            int itemToFind = 36;
            int index = result1.Linear_Search(data, itemToFind);
            Console.WriteLine((index >= 0) ? $"Item {itemToFind} found at position {index}" : $"Item {itemToFind} not found");

            itemToFind = 13;
            index = result1.Linear_Search(data, itemToFind);
            Console.WriteLine((index > 0) ? $"Item {itemToFind} found at position {index}" : $"Item {itemToFind} not found");

            itemToFind = 30;
            index = result1.Linear_Search(data, itemToFind);
            Console.WriteLine((index > 0) ? $"Item {itemToFind} found at position {index}" : $"Item {itemToFind} not found");

            Console.ReadLine();

        }
    }
}
