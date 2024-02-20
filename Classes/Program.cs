using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classlar temel olarak yapmak istediğimiz işlemleri gruplara ayırmak, o grup üzerinden işlemlerimizi yapmak
            //ve rahatlıkla bu gruba ulaşmak için kullanılır

            //classı burada kullanmak için bir örneğini oluşturmak gerekir

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //değer verdiğimiz zaman set etmiş oluyoruz
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            //yukarıdaki ve aşağıdaki tanımlama da aynıdır
            Customer customer2 = new Customer
            {
                //ctrl+space'e bas customer'ın propertyleri gelsin
                Id = 2, City = "İstanbul",FirstName = "Derin",LastName = "Demiroğ"
            };
            //burada ise sadece get bloğu çalışır
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
    
   

}
