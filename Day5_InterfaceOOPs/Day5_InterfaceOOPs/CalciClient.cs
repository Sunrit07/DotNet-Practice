using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_InterfaceOOPs
{
    internal class CalciClient
    {
        public static void Main()
        {
            ICalculator c = new Casio();
            int result = c.Add(4, 6);
            Console.WriteLine(result);

            int sub = c.Subtract(6, 3);
            Console.WriteLine(sub);

            int mull = c.Multiply(6, 3);
            Console.WriteLine(mull);

            int div = c.Divide(6, 3);
            Console.WriteLine(div);


        }
    }
}
