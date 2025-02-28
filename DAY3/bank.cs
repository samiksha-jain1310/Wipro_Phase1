using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
    public class BankAccount
    {
        public string AccountHolder;
        protected int AccountNumber;
        private double Balance;
        internal string BankName;

        BankAccount(string accholder, int accno, double balance, string bankname)
        {
            AccountHolder = accholder;
            AccountNumber = accno;
            Balance = balance;
            BankName = bankname;
        }


        public void showAccountDetails()
        {
            Console.WriteLine("Account Holder's Name: "+AccountHolder);

            Console.WriteLine("Bank Name: "+BankName);

        }
    }


    public class SavingAccount : BankAccount
    {
        public SavingAccount(string accholder, int accno, double balance, string bankname) : base(accholder, accno, balance, bankname)
        {
            
        }

        public void display()
        {
            Console.WriteLine("Account Number Protected"+AccountNumber);
        }
    }


public class Bank
{
    public static void Main(string[] args)
    {
        BankAccount b = new BankAccount("Samiksha Jain", 584262552, 500000.0, "SBI");
        b.showAccountDetails();
        
        SavingAccount s = new SavingAccount("Kajal Jain", 841215852, 7852.2, "IOB");
        s.display();
    }
}