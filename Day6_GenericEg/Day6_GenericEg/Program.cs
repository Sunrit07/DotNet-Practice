using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_GenericEg
{
    class ArrayEg
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of the array");
            int size;
            int.TryParse(Console.ReadLine(), out size);
            Console.WriteLine("Size" + size);
            if (size != 0)
            {
                int[] a = new int[size];
                Console.WriteLine("Enter the items");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Printing the items");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
