using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();

            var result = Add2(20, 30);
            Console.WriteLine(result);

            var result1 = Add3(30);
            Console.WriteLine(result1);

            //Engin hoca en sevdiği soruyu soruyor bu videoda  
            int number1 = 20;
            int number2 = 100;
            //Add4'e number1'in değeri gönderiliyor, adı değil.
            //Yani number1 yerine 20 yazsamda bir şey değişmez. Buradaki değişken metodun içindeki değişkeni etkileyemez.
            var result2 = Add4(number1, number2); //var result2 = Add4(ref number1, number2);
            //var result2 = Add4(out number1, number2);
            // ref ve out arasındaki fark --> ref'te metoddan önce mutlaka number1'ın set edilmiş olmalı ama out'ta böyle bir şart yok
            Console.WriteLine(result2); //130
            Console.WriteLine(number1); //20.Ancak methodda kullanırken ve burada çağırırken ref/out number1 dersek çıktı 30 olur

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6));

            Console.ReadLine();
        }

        //Methodlarla bir işlemi tek merkezden kontrol edebilme imkanı elde ederiz.
        //DRY(Do not repeat yourself) prensibi için kullanılır.
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        //void bir işlem yapmak için kullanılır ancak biz bir sonuç döndüreceğimiz için uygun veri tipini kullanmalıyız.
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;

            return result;
        }

        //Default parametre, eğer mainde fonksiyonu çağırırken herhangi bir sayı vermezsek otomatik olarak default parametreler kullanılır.
        //Ancak çağırırken sayı vermişsek bizim verdiğimiz sayı geçerlidir.
        //default değerler her zaman sondan başa doğru verilmeye başlamak zorundadır.(int number1 = 30,  int number2 gibi bir kullanım kabul edilmez)

        static int Add3(int number1, int number2 = 30)
        {
            var result = number1 + number2;

            return result;
        }

        //ref keyword
        static int Add4(int number1, int number2) //static int Add4(ref int number1, int number2)
        //static int Add4(out int number1, int number2)
        {
            //maindeki number1 ile buradakinin adının aynı olması bir şeyi değiştirmez. İkisi bambaşka değişkenlerdir.
            //out'ta gönderdiğin değerin methodda kullanmadan önce mutlaka set edilmiş olması lazım. refte bu şart yok
            number1 = 30;
            return number1 + number2;
        }

        //Method overloading
        //aynı isim kullanılarak iki method yazılabilir. parametreler farklı olacak

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //Params keyword
        //Her artan toplam için ekstra overloading yapmak gerekir ancak mantıklı değildir.Bu durumda params kullanmak daha mantıklıdır.
        
        static int Add5(params int[] numbers)
        //static int Add5(int number , params int[] numbers) bu şekilde sonuç 20 .ıkar. çünkü ilk deper number'a atanır
        {
            return numbers.Sum();
        }
    }
}
