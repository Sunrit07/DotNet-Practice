using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_GenericEg
{
    internal class HashtableEg
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Apple");
            ht.Add(102, "Banana");
            ht.Add(103, "Kiwi");
            ht.Add(104, "Chikku");
            ht.Add(105, null);
            Console.WriteLine("Display Keys");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Display Values");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Display Keys and Values");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine("Enter the search item");
            int search = Convert.ToInt32(Console.ReadLine());
            if (ht.ContainsKey(search))
            {
                Console.WriteLine(ht[search]);
            }
            else
            {
                Console.WriteLine("Sorry! item not found");
            }


        }
    }
}
