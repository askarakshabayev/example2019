using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment 1
            int a = int.Parse(Console.ReadLine());
            /*
             * comment 1
             * comment 2
             */           
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b + a + b);
        }
    }
}
