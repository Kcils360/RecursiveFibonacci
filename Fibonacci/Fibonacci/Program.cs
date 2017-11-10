using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Fibonacci go = new Fibonacci();
            go.FibSequence(0, 1, x);

            Console.ReadKey();
        }
    }
}
