using System;

namespace MoreOrLessInitiation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            long y = long.MaxValue;
            short z = short.MaxValue;

            ulong w = (ulong)(x + y + z);
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(w);    
        }
    }
}