using System;
namespace Demo
{
    public static class SDA
    {
        public static void run()
        {
            Console.WriteLine("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i=1; i<=n; i++) 
            {
                Console.WriteLine($"The element at indez {i} is {arr[i]}");

            }
        }
    }
}