/*
using System;
using System.Runtime.Intrinsics.X86;
namespace Encapsulation
{
    public class Vote
    {
        int Age;

        public double GetAge()
        {
            return Age;
        }

        public void SetAge(int People)
        {
            if(People >= 18 && People <= 100)
                Console.WriteLine("You are eligible to vote");
            else
            {
                Console.WriteLine("You are not eligible to vote");
                Console.WriteLine("Please wait for "+(18-People)+ " years to vote.");
            }
            this.Age = People;
        }
    }

    class Program : Vote
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");

            Vote v1 = new Vote();
            int n = Convert.ToInt32(Console.ReadLine());

            v1.SetAge(n);
        }
    }
}

*/

