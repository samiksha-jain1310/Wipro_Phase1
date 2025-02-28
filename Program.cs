using System;
namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
                /*
                Console.WriteLine("Enter the length of rectangle: ");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the width of rectangle: ");
                int width = Convert.ToInt32(Console.ReadLine());
                int area = length * width;
                
                Console.WriteLine($"The area of rectangle is: {area}");*/

            Console.WriteLine("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"The Addition of two numbers is: {c}");
        }
    }
}
