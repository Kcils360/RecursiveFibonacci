using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a NUMBER to find it's position in the Fibonacci Sequence");
            int x = Convert.ToInt32(Console.ReadLine());
            Fibonacci go = new Fibonacci();
            go.FibSequence(0, 1, x);

            Console.ReadKey();
        }
    }
}
