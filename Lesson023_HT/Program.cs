using System;

namespace Lesson023_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calculator1 = new Calculator();
            Console.WriteLine("Choose operation: ADD, MUL, SUB, DIV:");
            string answear = Console.ReadLine();
            if(answear == "add")
            {
                Console.WriteLine(calculator1.Add(2, 3));
            }
            if (answear == "mul")
            {
                Console.WriteLine(calculator1.Mul(2, 3));
            }
            if (answear == "sub")
            {
                Console.WriteLine(calculator1.Sub(2, 2));
            }
            if (answear == "div")
            {
                Console.WriteLine(calculator1.Div(2, 0));
            }
        }
    }
}
