using System;
using System.Runtime.Serialization;

namespace OOP
{

   class Person
    {    
        // Using 2 field-> name and age
        public string name;
        public int age;


        // Method-> DisplayInfo
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name},Age: {age}\n");
        }


        // Method-> SetValue
        public void SetValue(string n,int a)
        {
            name = n;
            age = a;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {   
            //Object-> p1
            Person p1 = new Person();

            p1.SetValue("Al Momen", 24);
            p1.DisplayInfo();
            
         

            // Object-> p2
            Person p2 = new Person();
            
            p2.SetValue("Muntasir Asif", 25);
            p2.DisplayInfo();
            
            
        }   
    }
}
