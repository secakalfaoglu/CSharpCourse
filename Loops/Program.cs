using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoops();

            if (IsPrimeNumber(5))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        //sayı asal mı değil mi ? 
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0) //bölme işlemi için yüzde işareti kullanılır
                {
                    result = false;
                    i = number; //bölünebildiği ilk sayıda döngü dönmeyi bıraksın diye bunu ekledik. performans iyileştirmesi 
                }
            }
            return result;
        }

        private static void ForEachLoops()
        {
            //ForEach Döngüsü
            //Dizi temelli yapıların dolaşılması için kullanılır.
            //en çok kullanılan döngü tipidir.
            //Diğer döngülerde diziler için kullanılabilir. ancak foreach döngüsü bunun için daha pratik bir döngüdür.


            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            //Do While Döngüsü
            //While döngüsünden tek farkı önce çalışır sonra şarta bakar. 
            //yukarıdaki sebepke şart sağlanmasa bile do döngüsü  bir kere çalışacaktır.
            //örneğin data yoksa bağlantıyı kapatma gibi bir yapıda kullanılabilir.
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            //While Döngüsü
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--; //sonsuz döngü olmasını engelleidk bu sayede.
            }

            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            //Main'in içindeydi.Kodu seçip sağ tıkladık refactor --> extract --> extract method seçtikve böylece bu kodu bir method haline getirdik.
            //veri kümesini dolaşmak için kullanılan yapılara döngüler diyoruz.
            //i değişkeni tanımlandığı blokta kullanılır sadece. public değişken gibi düşün.
            //i 100'den küçük eşit olduğu sürece çalışacak bu döngü. şart bu 
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
            //for (int i = 1; i <= 100; i+=2) -- tek sayılar için 
            //for (int i = 1; i <= 100; i=i+2) -- tek sayılar için 
            //for (int i = 2; i <= 100; i=i+2) -- çift sayılar için 
            //for (int i = 100; i <= 0; i=i-1) -- 100'den geriye
        }
    }
}
