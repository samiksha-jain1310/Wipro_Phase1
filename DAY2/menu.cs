using System;
namespace Demo
{
    public static class Restaurant
    {
        public static void Menu()
        {
            int choice;
            int totalPrice = 0;
            do
            {
                Console.WriteLine("1. Pizza - Rs.100");
                Console.WriteLine("2. Burger - Rs.50");
                Console.WriteLine("3. Pasta - Rs.200");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Selected Pizza - Rs.100");
                        totalPrice += 100;
                        break;
                    case 2:
                        Console.WriteLine("Selected Burger - Rs.50");
                        totalPrice += 50;
                        break;
                    case 3:
                        Console.WriteLine("Selected Pasta - Rs.200");
                        totalPrice += 200;
                        break;
                    case 4:
                        Console.WriteLine("Chose to exit the program.");
                        Console.WriteLine($"Total price: Rs.{totalPrice}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 4);
        }
    }
}