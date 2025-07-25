using Day7_Calcilib;      // it should be public all interface and classes too
namespace CalciProject
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            ICalculator obj = new Calculator();
            Console.WriteLine(obj.add(a, b));
        }
    }
}