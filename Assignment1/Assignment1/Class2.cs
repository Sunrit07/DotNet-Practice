using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class2
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");
            Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
            Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2}");

        }
    }
}
