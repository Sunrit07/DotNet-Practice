using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_InterfaceOOPs
{
    internal class AgeNotValidException:ApplicationException
    {
        public AgeNotValidException(string msg):base(msg) { }
    }
    class Voting
    {
        public void CheckAge(int  age)
        {
            if(age > 18)
            {
                Console.WriteLine("Thanks for voting...");
            }
            else
            {
                throw new AgeNotValidException("Sorry! you are not eligible for voting...");
            }
        }
    }
}
