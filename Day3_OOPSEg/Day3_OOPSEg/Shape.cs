using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_OOPSEg
{
    internal class Shape
    {
        public string? Color { get; set; }
        public float Area { get; set; }
        public void Accept()
        {
            Console.WriteLine("Enter Color: ");
            Color = Console.ReadLine();
        }

        public void CalculateArea()
        {
            Console.WriteLine("Calculate area method of shape class: ");
        }
        public void Display()
        {
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Area: "+ Area);
        }
    }

    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public void GetRectDetails()
        {
            Console.WriteLine("Enter length and breadth: ");
            Length = Convert.ToInt32(Console.ReadLine());
            Breadth = Convert.ToInt32(Console.ReadLine());

        }

        public void CalculateRectArea()
        {
            Area = Length * Breadth;

        }

        public void ShowRectDetails()
        {
            Console.WriteLine("Length " + Length + " Breadth: " + Breadth);
        }
    }
}
