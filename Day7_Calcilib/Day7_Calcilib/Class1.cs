namespace Day7_Calcilib
{
    // For reusability
    public interface ICalculator
    {
        int add(int x, int y);
    }

    public class Calculator : ICalculator
    {
        public int add(int x, int y)
        {
            return x+y;
        }
    }
}
