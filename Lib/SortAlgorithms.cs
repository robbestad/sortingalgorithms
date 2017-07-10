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

        private static readonly Random rng = new Random();

        public List<int> Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }

    public class SortAlgorithms
    {
        // The input array is updated in the for loop below
        // and returned after the while loop exits

        public static IEnumerable<int> BubbleSort(List<int> array)
        {
            Helper helper = new Helper();

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
                    array = helper.Swap(array, i);
                    isSorted = true;
                }
            } while (isSorted);

            return array;
        }

        public static void Main(string[] args)
        {
            Helper helper = new Helper();

            SortAlgorithms algos = new SortAlgorithms();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<int> values = Enumerable.Range(1, 1500).ToList();
            IEnumerable<int> sortedList = BubbleSort(helper.Shuffle(values));
            watch.Stop();

            int counter = 0;
            var listItems = sortedList as IList<int> ?? sortedList.ToList();
            int num = listItems.Count();

            Console.WriteLine("Bubble Sort");

            foreach (int listItem in listItems)
            {
                counter++;
                Console.Write(listItem);
                if (counter < num)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Time taken: {0}ms", watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
