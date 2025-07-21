using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOPSEg
{
    internal class ShapeClient
    {
        public static void Main()
        {
            Shape s = new Circle();
            s.Accept();
            s.CalculateArea();
            s.Display();
        }
    }
}
