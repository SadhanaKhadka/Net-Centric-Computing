using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NccLabSadhana
{
    internal class Evennumbers
    {
        internal class Array
        {
            static void Main(string[] args)
            {
                int[] array = new int[30];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = (i + 1) * 2;
                    Console.WriteLine("array [" + i + "] = " + array[i]);
                }
            }
        }
    }
}
