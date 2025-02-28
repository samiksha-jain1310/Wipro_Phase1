/*create a program to preserve the original string value (Password123) 
even after modifying the variable , how we can achieve this and also how we 
restrict to modify the password in the original variable. 
 
Let's say you have to ensure that once the password is set , it cannot be 
changed accidentally. 
*/



using System;
namespace Security
{
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
    }
}
