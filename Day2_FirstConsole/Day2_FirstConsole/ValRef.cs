using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_FirstConsole
{
    struct Student
    {
        public int MathsMarks;
        public int ScienceMarks;
    }
    internal class ValRef
    {
        public static void main(string[] args)
        {
            Student Ram = new Student();
            Ram.MathsMarks = 40;
            Ram.ScienceMarks = 50;
            Student Sita = Ram;
            Console.WriteLine("Ram's Mathsmark: "+Ram.MathsMarks);
            Console.WriteLine("Ram's Sciencemark: "+Ram.ScienceMarks);
            Console.WriteLine("Sita's Mathsmark: " +Sita.MathsMarks);
            Console.WriteLine("Sita's Sciencemark: " +Sita.ScienceMarks);
            Ram.MathsMarks = 80;
            Ram.ScienceMarks = 90;
            Console.WriteLine("Ram's Mathsmark: " +Ram.MathsMarks);
            Console.WriteLine("Ram's Sciencemark: " +Ram.ScienceMarks);
            Console.WriteLine("Sita's Mathsmark: " +Sita.MathsMarks);
            Console.WriteLine("Sita's Sciencemark: " +Sita.ScienceMarks);
        }
    }
}
