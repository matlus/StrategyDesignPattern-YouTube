using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingStrategyHeap : SortingStrategyBase
    {
        public override int[] Sort(int[] numbers)
        {
            return HeapSort(numbers, Comparer<int>.Default.Compare);
        }

        private static int[] HeapSort(int[] numbers, Comparison<int> comparison)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int index = i;
                int item = numbers[i];

                while (index > 0 &&
                    comparison(numbers[0 + (index - 1) / 2], item) < 0)
                {
                    int top = (index - 1) / 2;
                    numbers[index] = numbers[top];
                    index = top;
                }
                numbers[index] = item;
            }

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int last = numbers[i];
                numbers[i] = numbers[0];

                int index = 0;
                while (index * 2 + 1 < i)
                {
                    int left = index * 2 + 1, right = left + 1;

                    if (right < i && comparison(numbers[left], numbers[right]) < 0)
                    {
                        if (comparison(last, numbers[right]) > 0) break;

                        numbers[index] = numbers[right];
                        index = right;
                    }
                    else
                    {
                        if (comparison(last, numbers[left]) > 0) break;

                        numbers[index] = numbers[left];
                        index = left;
                    }
                }
                numbers[index] = last;
            }

            return numbers;
        }
    }
}
