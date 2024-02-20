using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        //Interface aslında bir inheritance değildir  inheritance gibi kullanılabilir
        //amaç uygulamanın bağımlılıklarını sıfıra indirgemektir
        static void Main(string[] args)
        {
            // InterfacesIntro();
            //interface new'lenemez çünkü tek başına bir anlamı yoktur.
            //IPerson person = new IPerson(); --> bu olmaz
            //IPerson person = new Customer(); --> bu olur

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //manager.Add(new Customer{Id=1,FirstName = "Engin", LastName ="Demiroğ",Address = "Ankara"});
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Department = "Computer Sciences"
            };

            manager.Add(customer);
            manager.Add(student);
        }
    }
    //soyut nesne
    //burada tanımlanan özellikler/methodlar bu interface'i kullanan classlar tarafından kullanılmak zorundadır.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    //somut nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
    //somut nesne
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    //somut nesne
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        //IPerson yaptığım için hem customer hem student'ta kullanabildim bu fonksiyonu
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
