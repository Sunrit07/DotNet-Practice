using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_GenericEg
{
    internal class ArrayListEg
    {
        public static void Main()
        {
            ArrayList l1 = new ArrayList();
            l1.Add(89);
            l1.Add(78);
            l1.Add(99);
            l1.Add(34);
            l1.Add(62);
            l1.Sort();
            Console.WriteLine("After sorting l1");
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }
            ArrayList al = new ArrayList();
            al.Add("10"); //object is a super datatype which can take any datatype
            al.Add(89);
            al.Add("Vedantha");
            al.Add(true);
            al.Insert(1, "Ram");
            al.InsertRange(3, l1);
            Console.WriteLine("Display items");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            al.Remove(89);
            al.RemoveAt(2);
            Console.WriteLine("Count: " + al.Count);

            Console.WriteLine("Displaying items after Removing");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }



        }
    }
}
