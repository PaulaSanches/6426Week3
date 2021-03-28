using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public static class inClassLib
    {
        public static int ArrayLinearSearch(int[] array, int value)
        {
            ///loop through the array
            for (int i = 0; i < array.Length; i++)
            {
                ///if the i'th value in the array is what we want
                if (array[i] == value)
                {
                    return i;
                }

                ///return the index was found at

                /// return a fall to find

            }
            return -1;
        }

        public static int ArrayBinarySearch(int[] array, int value)
        {
            return 0;
        }

        public static int ArrayRecursivelLinearSearch(int[] array, int index, int value)
        {


            if (index >= array.Length)
                return -1;
            if (array[index] == value)
                return index;
            return ArrayRecursivelLinearSearch(array, index + 1, value);
        }
    }
}
       