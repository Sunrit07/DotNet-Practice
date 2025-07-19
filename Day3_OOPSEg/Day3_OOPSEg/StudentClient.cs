using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_OOPSEg
{
    internal class StudentClient
    {
        public static void Main()
        {
            Student s1 = new Student();
            s1.Accept();
            s1.Display();
            Student s2 = new Student();
            s2.Accept();
            s2.Display();
        }
    }
}
