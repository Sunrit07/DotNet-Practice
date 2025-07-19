namespace Day3_OOPSEg
{
    class Student
    {
        int sid;
        string sname;
        int age;

        public void Accept()
        {
            Console.WriteLine("Enter Sid, Sname and Age");
            sid = Convert.ToInt32(Console.ReadLine());
            sname = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Your details are: ");
            Console.WriteLine("SID: "+sid+" Name: "+sname+" Age: "+age);
        }
    }
}