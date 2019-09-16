using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingStrategyInsertion : SortingStrategyBase
    {
        public override int[] Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i], j = i - 1;
                while (j >= 0 && numbers[j] > temp)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = temp;
            }

            return numbers;
        }
    }
}
