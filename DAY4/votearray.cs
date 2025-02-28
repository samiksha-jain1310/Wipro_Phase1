using System;
namespace Encapsulation
{
    class Vote
    {
        private string name1;
        private int age1;

        public string Name
        {
            get{ return name1; }
            set{ name1 = value; }
        }

        public int Age
        {
            get{ return age1; }

            set
            {
                age1 = value;

                if(age1 >= 18 && age1 <= 100)
                    Console.WriteLine("You are eligible to vote.");

                else
                {
                    Console.WriteLine("You are not eligible to vote");
                    Console.WriteLine("Please wait for "+(18-Age)+ " years to vote.");
                }
                this.age1 = Age;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of voters: ");
            int CountVoters = Convert.ToInt32(Console.ReadLine());

            Vote[] voters = new Vote[CountVoters];

            for(int i=0 ; i<CountVoters; i++)
            {
                voters[i] = new Vote();

                Console.WriteLine($"Enter the name of voter {i+1}: ");
                voters[i].Name = Console.ReadLine();

                Console.WriteLine($"Enter your age {voters[i].Name}: ");
                voters[i].Age = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}