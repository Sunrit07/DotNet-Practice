using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_FirstConsole
{
    class Second
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            int age;
            Console.WriteLine("Enter your Age: ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Age:");
            }

            DateTime dob;
            Console.WriteLine("Enter your DOB (e.g. 01/01/2000): ");
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid input. Please enter a valid date (e.g. 01/01/2000):");
            }

            float salary;
            Console.WriteLine("Enter your salary: ");
            while (!float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out salary))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for salary (use . as decimal separator):");
            }

            bool result;
            Console.WriteLine("Enter the result (true/false or yes/no): ");
            while (true)
            {
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "true" || input == "yes" || input == "y")
                {
                    result = true;
                    break;
                }
                else if (input == "false" || input == "no" || input == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'true', 'false', 'yes', or 'no':");
                }
            }

            Console.WriteLine("Your Details are :");
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is {0} and dob is {1}", age, dob.ToShortDateString());
            Console.WriteLine($"Your result is {result}");
            Console.WriteLine("Your salary is {0}", salary);
        }
    }
}
