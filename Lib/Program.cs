using System;
using System.Collections.Generic;
using System.Linq;

namespace SortExamples
{
    internal class Helper
    {
        // Helper func for clarity in main loop
        public List<int> Swap(List<int> array, int i)
        {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
            return array;
        }

    }

    internal class SortAlgorithms
    {
        // The input array is updated in the for loop below
        // and returned after the while loop exits
        readonly Helper _helper = new Helper();

        private IEnumerable<int> BubbleSort(List<int> array)
        {

            bool isSorted = false;

            do
            {
                // Set the sorted bool to false
                // if the for loop passes without setting
                // the bool to true, the array is sorted
                int n = array.Count;
                isSorted = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] <= array[i + 1]) continue;
                    array = _helper.Swap(array, i);
                    isSorted = true;
                }
            } while (isSorted);

            return array;
        }

        public static void Main(string[] args)
        {

            SortAlgorithms Algos = new SortAlgorithms();

            IEnumerable<int> sortedList = Algos.BubbleSort(new List<int>() { 100, 2, 4473, 1, 474, 5, 7, 3, 55, 4, 8, 12 });

            int counter = 0;
            foreach (int listItem in sortedList)
            {
                counter++;
                Console.Write(listItem);
                if (counter < sortedList.Count())
                {
                    Console.Write(",");
                }
            }
            Console.ReadKey();
        }
    }
}
