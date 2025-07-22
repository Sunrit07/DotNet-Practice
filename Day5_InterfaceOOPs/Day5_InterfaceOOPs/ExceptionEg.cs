using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_InterfaceOOPs
{
    internal class ExceptionEg
    {
        public static void Main()
        {
            int a, b, c = 0;
            try
            {
                Console.WriteLine("Enter 2 numbers: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            catch(FormatException) 
            {
                Console.WriteLine("Please enter only numbers...");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Second number can't be zero...");
            }
            catch (Exception ex)  //All exception
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Result: " + c);


        }
    }
}
