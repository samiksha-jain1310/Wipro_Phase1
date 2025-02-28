/*using System;
namespace DAY3
{
    public class Demo1  //parent class of Demo2
    {
        public int ID;   //private protected access specifier 

        public void display()
        {
            Console.WriteLine(ID);  //you can access the private member within the type
        }
    }


    public class Demo2 : Demo1  //child class of Demo1
    {
        public void display1()
        {
            Console.WriteLine(ID);  //you cannot access the private member in any of the derived class
        }
    }


    public class Demo3  //non-derived class
    {
        public void display()
        {
            Console.WriteLine(ID);  //you cannot access the private member in any of the nob-derived class
        }
    }
}


*/