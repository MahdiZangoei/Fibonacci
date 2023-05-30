using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a Number :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
            Console.WriteLine("\n \n \n     Press any key for exit...");

            Console.ReadKey();
        }
        static int Fib(int n) 
        {
            if (n <= 1) 
            {
                return n;
            }
            else 
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
