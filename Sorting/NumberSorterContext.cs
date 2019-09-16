using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class NumberSorterContext
    {
        private enum SortAlogorithmToUse
        {
            Insertion,
            Heap,
            Quick
        }

        public int[] Sort(int[] numbers)
        {
            var sortAlgorithmToUse = DetermineSortAlogorithmToUse(numbers);

            SortingStrategyBase sorter = null;

            switch (sortAlgorithmToUse)
            {
                case SortAlogorithmToUse.Insertion:
                    sorter = new SortingStrategyInsertion();
                    break;
                case SortAlogorithmToUse.Heap:
                    sorter = new SortingStrategyHeap();
                    break;
                case SortAlogorithmToUse.Quick:
                    sorter = new SortingStrategyQuick();
                    break;
                default:
                    throw new SortAlgorithmNotSupportedException($"The Sort Algorithm: {sortAlgorithmToUse}, is not supported");
            }

            return sorter.Sort(numbers);
        }

        /// <summary>
        /// If the partition size is fewer than 16 elements, it uses an insertion sort algorithm.
        /// If the number of partitions exceeds 2 * LogN, where N is the range of the input array, it uses a Heapsort algorithm.
        /// Otherwise, it uses a Quicksort algorithm.
        /// </summary>
        /// <param name="numbers">array of int</param>
        /// <returns>SortAlogorithmToUse</returns>
        private SortAlogorithmToUse DetermineSortAlogorithmToUse(int[] numbers)
        {
            var midIndex = numbers.Length / 2;
            var midValue = numbers[midIndex];

            int min = int.MaxValue;
            int max = int.MinValue;

            int countOfLessThan = 0;
            int countOfGreaterThan = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (min > number)
                    min = number;

                if (max < number)
                    max = number;

                if (number > midValue)
                    countOfGreaterThan++;

                if (number < midValue)
                    countOfLessThan++;
            }

            var range = max - min;
            var partitionSize = countOfGreaterThan < countOfLessThan ? countOfGreaterThan : countOfLessThan;
            var partitionThreshold = Convert.ToInt32(2 * Math.Log(range));

            if (partitionSize > partitionThreshold)
                return SortAlogorithmToUse.Heap;
            else if (partitionSize < 16)
                return SortAlogorithmToUse.Insertion;
            else
                return SortAlogorithmToUse.Quick;
        }
    }
}
