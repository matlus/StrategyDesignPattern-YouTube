using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingStrategyQuick : SortingStrategyBase
    {
        public override int[] Sort(int[] numbers)
        {
            return Sort(numbers.ToList()).ToArray();
        }

        private static List<int> Sort(List<int> numbers)
        {
            var loe = new List<int>();
            var gt = new List<int>();

            if (numbers.Count < 2)
                return numbers;

            int pivot = numbers.Count / 2;
            int pivot_val = numbers[pivot];
            numbers.RemoveAt(pivot);

            foreach (int i in numbers)
            {
                if (i <= pivot_val)
                    loe.Add(i);
                else 
                    gt.Add(i);
            }

            List<int> resultSet = new List<int>();
            resultSet.AddRange(Sort(loe));
            if (gt.Count == 0)
            {
                loe.Add(pivot_val);
            }
            else
            {
                gt.Add(pivot_val);
            }
            resultSet.AddRange(Sort(gt));
            return resultSet;
        }
    }
}
