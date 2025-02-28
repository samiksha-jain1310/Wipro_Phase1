using System;
using System.Runtime.CompilerServices;
namespace Demo

{
    public static class EvenOdd
    {
        public static void run()
        {
            Console.WriteLine("Enter the number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if(i>=2 && i<=20)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Entered number is Even number");
                }
                else
                {
                    Console.WriteLine("Entered number is Odd");
                }
            }
            else
            {
                Console.WriteLine($"{i} is greater than 20 and less than 2");
            }
        }

    }
}