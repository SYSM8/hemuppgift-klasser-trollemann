using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hemuppgift06
{
    public class Person
    {
        //properties
        private string forename;
        public string Forename
        {
            get 
            { 
                return forename; 
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("forename can't be empty");
                }
                else
                {
                    forename = value;
                }
            }
        }
        private string surname;
        public string Surname
        {
            get 
            {
                return surname; 
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("surname can't be empty");
                }
                else
                {
                    surname = value;
                }
            }
        }
        private int age;
        public  int Age
        {
            get 
            { 
                return age; 
            }
            set
            {
                if(age < 0)
                {
                    Console.WriteLine("age can't be negative");
                }
                else
                {
                    age = value;
                }
            }
        }

        //constructor
        public Person(string forename, string surname, int age)
        {
            Forename = forename;
            Surname = surname;
            Age = age;
        }
        
        //method
        public void GetFullName()
        {
            Console.WriteLine($"{Forename} {Surname}");
        }
    }
}
