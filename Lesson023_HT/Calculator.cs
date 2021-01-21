using System;
namespace Lesson023_HT
{
    public class Calculator
    {
        public Calculator()
        {
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            try
            {
                int res = x / y;
                return res;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            return 0;
        }
    }
}
