using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        //SOLID - Interface Segregation
        //interfacelerin doğru planlanması
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker , ISalary, IEat
    {
        public void Work()
        {
            Console.WriteLine("Managers work");
        }

        public void GetSalary()
        {
            Console.WriteLine("Managers get paid");
        }

        public void Eat()
        {
            Console.WriteLine("Managers eat");
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Work()
        {
            Console.WriteLine("Workers work");
        }

        public void GetSalary()
        {
            Console.WriteLine("Workers get paid");
        }

        public void Eat()
        {
            Console.WriteLine("Workers eat");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robots work");
        }
    }
}
