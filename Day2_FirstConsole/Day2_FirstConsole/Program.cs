namespace Day2_FirstConsole
{
    class Program
    {
        public static void main(string[] args) 
        {
            Console.WriteLine("Enter two numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int res = x + y;
            if (res>10)
            {
                Console.WriteLine("Print result is greater than 10");
            }
            else
            {
                {
                    Console.WriteLine("Result is less than 10");
                }
            }
            Console.WriteLine("The result is " + res);
        }
    }
}