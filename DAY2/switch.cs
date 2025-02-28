using System;
namespace Demo
{
    public static class Switch 
    {
        public static void order()
        {
            bool ord = true;
            while(ord)
            {
                Console.WriteLine("Select Menu: \n1. Pizza: 100Rs\n2. Burger: 60Rs\n3. Pasta:200Rs ");

                Console.WriteLine("Enter your choice: ");
                int item = Convert.ToInt32(Console.ReadLine());

                switch(item)
                {
                    case 1:
                        Console.WriteLine("You selected Pizza.\nYour bill is 100Rs.");
                        break;
                    case 2:
                        Console.WriteLine("You selected Burger.Your bill is 50Rs.");
                        break;
                    case 3:
                        Console.WriteLine("You selected Pasta.Your bill is 200Rs.");
                        break;
                    case 4:
                        Console.WriteLine("Your selected to exit the Menu.");
                        ord = false;
                        break;
                }
            }
        }
    }
}