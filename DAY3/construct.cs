
/*
class Test

{
    /*
    int i;
    int a;

    //No args based constructor
    public Test()
    {
        Console.WriteLine("Constructor defined Implicitly during object creation");
        Console.WriteLine(i);
    
    }
    // args based constructor
    public Test(int a  , int b)
    {
        Console.WriteLine("Constructor defined Explicitly");
       
       this.a = a;
        Console.WriteLine($"The value of a local variable : {a} ");
        Console.WriteLine(this.a); //this keyword resolves the ambiguity between the instance variable and local variable
    }
    public static void Main(string[] args)
    {
        Test t = new Test();
        Test t1 = new Test(20, 30);
    }
    
}
*/


/*Constructor is a special method present inside a class responsible 
for initializing the variable of that class*/






// default constructor and parameterized constructor
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    internal class Person
    {
        public string Name;
        public int Age;

        // default constructor
        public Person(string name , int age) 
        {
            Name = name;
            Age = age;
        }

        public Person(Person p)
        { 
            Name = p.Name;
            Age = p.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name} and Age : {Age}");
        }

    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Samiksha", 23);
            person1.Display();

            Person person2 = new Person(person1);
            person2.Display();

            person2.Name = "Shree";
            person2.Age = 24;
            person2.Display();
        }
    
    }
}
*/
