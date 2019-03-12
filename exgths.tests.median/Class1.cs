using System;
using System.Collections.Generic;
using System.Linq;

namespace exgths.tests.median
{
    public class Class1
    {
        public double Median(int[] array)
        {
            if (null == array)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array shouldn't be empty!");
            }

            if (array.Length == 1)
            {
                return array[0];
            }

            List<int> list = array.OrderBy(x => x).ToList();

            if (list.Count % 2 == 1)
            {
                return list.ElementAt(list.Count / 2);
            }
            return (list.ElementAt((list.Count / 2) - 1) + list.ElementAt(list.Count / 2)) / 2.0;

        }
    }
}
