using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal static class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            var minValue = 1900;
            var maxValue = 2019;
            int[] numbers = Enumerable.Range(minValue, maxValue - minValue + 1).OrderBy(i => random.Next(minValue, maxValue)).ToArray();

            var numberSorter = new NumberSorterContext();
            var sortedNumbers = numberSorter.Sort(numbers);

            PrintMinMaxMedian(sortedNumbers);
            Console.ReadLine();
        }

        private static void PrintMinMaxMedian(int[] sortedNumbers)
        {
            var len = sortedNumbers.Length;
            var min = sortedNumbers[0];
            var max = sortedNumbers[len - 1];

            int midPoint = len / 2;
            double median = (len % 2 != 0) ? (double)sortedNumbers[midPoint] : ((double)sortedNumbers[midPoint] + (double)sortedNumbers[midPoint - 1]) / 2;
            Console.WriteLine("Min: {0}\r\nMax: {1}\r\nMedian: {2}", min, max, median);
        }
    }
}
