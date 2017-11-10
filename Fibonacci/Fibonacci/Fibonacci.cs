using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        public int FibSequence(int a, int b, int x) //x here is a counter, the value that was given by the user
        {
            if(x != 2)
            {
                int c = a + b; //fibonacci math!
                x--;
                FibSequence(b, c, x);  //This makes this method recursive, by calling itself again, passing the new values
            }
            Console.WriteLine(b);
            return b;
            
        }

    }
}
