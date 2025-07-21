using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOPSEg
{
    internal class Shape
    {
        public string Color { get; set; }
        public float Area { get; set; }
        public virtual void Accept()
        {

            Console.WriteLine("Enter Color: ");
            Color = Console.ReadLine();
        }

        public virtual void CalculateArea()
        {
            Console.WriteLine("Calculate area method of shape class: ");
        }
        public virtual void Display()
        {
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Area: " + Area);
        }
    }

    class Circle : Shape
    {
        public int Radius { get; set; }
        public override void  Accept()
        {
            base.Accept();
            Console.WriteLine("Enter radius: ");
            Radius = Convert.ToInt32(Console.ReadLine());

        }

        public override void CalculateArea()
        {
            base .CalculateArea();
            Area = float.Parse((3.14 * Radius * Radius).ToString()); ;

        }

        public override void Display()
        {
            Console.WriteLine("Radius: " + Radius);
            base.Display();
        }
    }
}
