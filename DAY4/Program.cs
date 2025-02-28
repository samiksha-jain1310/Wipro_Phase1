
/*
using System;
namespace Encapsulation
{
    public class Bank
    {
        //Hiding the member variable not to access directly 
        public double Balance;

        public double GetBalance()
        {
            return Balance;
        } 

        public void SetBalance(double BalanceAmount)
        {
            if(BalanceAmount > 0)
            {
                this.Balance = BalanceAmount;
            }
            else 
            {
                Console.WriteLine("Negative value not allowed.");

            }
        }
    }


    class Program : Bank
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount: ");
            double am =  Convert.ToDouble(Console.ReadLine());

            Bank b1 = new Bank();
            Console.WriteLine(b1.Balance);

            b1.SetBalance(am);
            Console.WriteLine(b1.GetBalance());
        }
    }
}

*/