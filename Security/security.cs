using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    internal class MemoryExample
    {
        public string Name;
        public static void Main(string[] args)
        {

            //value type
            int a = 10;
            int b = 20;



            b = 20;
yes
            Console.WriteLine($"a= {a} , b= {b}");


            //reference type
            MemoryExample e = new MemoryExample();
            e.Name = "CSharp";

            MemoryExample e1 = e;
            e1.Name = "Java";
            Console.WriteLine(e.Name);
    }
    }
}

//getter setter

class MemoryExample
    {
         public static void Main(string[] args)
         {
        
            Password a=new Password("Password123");
            a.setPassword("345");
            Console.WriteLine(a.getPassword());
         }
    }
    public class Password
    {
        private readonly string P;
        public Password(string pass)
        {
           P=pass;
        }
        public string getPassword()
        {
           return P;
        }
        public void setPassword(string newpass)
        {
          Console.WriteLine("Password cannot be modified..");
          
        }