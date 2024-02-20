using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"},
                new Student{FirstName="Derin"},
                new Person{FirstName="Salih"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Person2
    {

    }
    //customer'ın babası :) person'dır.
    //her class en fazla bir sınıftan miras alır. yani person2'yi yazamazsın. Interface ile farklarından biri budur
    class Customer : Person //,Person2
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
