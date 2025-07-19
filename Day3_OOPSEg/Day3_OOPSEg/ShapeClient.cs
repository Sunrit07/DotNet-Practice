using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_OOPSEg
{
    internal class ShapeClient
    {
        public static void Main()
        {
            Rectangle s = new Rectangle();
            s.Accept();
            s.GetRectDetails();

            s.CalculateArea();
            s.CalculateRectArea();

            s.ShowRectDetails();
            s.Display();
        }
    }
}
