using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_InterfaceOOPs
{
    internal class VotingException
    {
        public static void Main()
        {
            Voting c1 = new Voting();
            Console.WriteLine("Enter your Age: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                c1.CheckAge(age);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers...");
            }
            catch (AgeNotValidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
