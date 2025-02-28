/*
using System.Collections;

namespace CollectionExample

{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 c = new Class1();


            // adding elements using object initializer syntax
            var arraylist = new ArrayList()
            {
                102,"Niti", "Dwivedi",true , 34.50 
    

            };

            //converting primitive to object is boxing and object to primitive is unboxing
            var fe = (int)arraylist[0]; //unboxing
            var se = (double)arraylist[4];

            Console.WriteLine($"{fe} , {se}");

            arraylist[0] = "MoreValue";
            arraylist[1] = 1101;

           // arraylist[5] = 1101;

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);

            }

        }
    }

}
*/



/*
using System;
using System.Collections.Generic;

class Student
{

    // initializing variables
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a list of students
        List<Student> students = new List<Student>
        {
            new Student 
            { 
                Id = 1, Name = "Samiksha", Age = 20 
            },
            new Student 
            { 
                Id = 2, Name = "Siddharth", Age = 22 
            },
            new Student 
            { 
                Id = 3, Name = "Lissa", Age = 21 
            }
        };

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Display Students");
            Console.WriteLine("2. Find Student by ID");
            Console.WriteLine("3. Remove Student by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nList of Students:");
                    students.ForEach(s => Console.WriteLine(s));
                    break;

                case "2":
                    Console.Write("\nEnter Student ID to Find: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());     
                    Student foundStudent = students.Find(s => s.Id == searchId);
                    // s represents each student object in the list.
                    // It checks if s.Id matches searchId.
                    // If a match is found, that student is returned.
                    //Console.WriteLine(s) automatically prints the student details in a formatted way.
                    
                    if (foundStudent != null)
                        Console.WriteLine($"Student Found: {foundStudent}");
                    else
                        Console.WriteLine("Student not found.");
                    break;

                case "3":
                    Console.Write("\nEnter Student ID to Remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    int removed = students.RemoveAll(s => s.Id == removeId);
                    
                    if (removed > 0)
                        Console.WriteLine("Student removed successfully.");
                    else
                        Console.WriteLine("Student ID not found.");
                    break;

                case "4":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}

*/
