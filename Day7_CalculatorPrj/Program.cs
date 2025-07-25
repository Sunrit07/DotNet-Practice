namespace Day7_CalculatorPrj
{
    public interface ICalculator
    {
        int add(int x, int y);
        int subtract(int x, int y);
        int multiply(int x, int y);
        int divide(int x, int y);
        int inc(int x);

        string message(string name);
        bool checkAge(int age);

        string Login(string username, string password);
        int CheckTemp(bool check);


    }

    public class Calculator : ICalculator
    {
        public int inc(int x)
        {
            return x + 1;
        }
        public int add(int x, int y)
        {
            int z = inc(x);
            return z + y;
        }
        public int subtract(int x, int y)
        {
            return x - y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }
        public int divide(int x, int y)
        {
            return x / y;
        }

        public string message(string name)
        {
            return "Hello " + name;
        }

        public bool checkAge(int age)
        {
            if (age > 18)
                return true;
            else
                return false;
        }

        public int CheckTemp(bool check)
        {
            if (check)
            {
                return 42;
            }
            else
            {
                throw new InvalidOperationException("temprature not initialized");
            }
        }

        public string Login(string username, string password)
        {
            string msg;
            if ((username == "user_1" && password == "secret@user11") || (username == "user_2" && password == "secret@user22"))
            {
                msg = "welcome " + username;
            }
            else
            {
                msg = "invalid user";
            }
            return msg;
        }
    }

}