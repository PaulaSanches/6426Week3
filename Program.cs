using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///inClassLib.ArrayLinearSearch()
            ///Random r = new Random();
            ///int[] array = new int[100];
            ///for(int i= 0; i < array.Length; i++)

            int[] myNewArray = Enumerable.Range(0, 100).ToArray();
            int i = inClassLib.ArrayRecursivelLinearSearch(myNewArray, 0, 20);
        }

    }
}
    
