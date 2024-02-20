using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types -- Değer Tipleri
            //Console.WriteLine("Hello World");

            //int -21471483648 ile +21471483647 sınırları içerisindeki tam sayılar için kullanılır.
            //bellekte 32 bit yer kaplar

            //type //variable // value
            int number1 = 10;

            //long bellekte int'in tam iki katı  yer tutar.
            //long integerı kapsar
            //bellekte veri tipine göre static bir yer tanımlanır.
            //bellekte fazla yer tutmaması için ihtiyaç hangi veri tipiyse onu kullanmak gerekir.
            //bellekte 64 bit yer kaplar.
            long number2 = 21471483648;

            //short bellekte 16 bit yer kaplar
            //-3268 +3267 sınırlarıdır
            long number3 = 3267;

            //byte veri tipi bellekte 8 bit yer kaplar
            //0 ile 255 sınırlarında değer alabilir.
            byte number4 = 255;

            //mantıksal veri tipi. false ya da true değeri tutabilir.
            bool condition = true;

            //char 
            //ASCII karakterleri tutmak için kullanılabilir
            char character = 'A';

            //double ondalıklı sayılar tutulabilir .
            //bellekte 64 bitlik yer tutar
            //virgülden sonra 15-16 değer tutar
            double number5 = 10.5;

            //decimal 
            //int için long neyse double için decimal aynı şeydir.
            //para tutarı için bunu kullanmak daha mantıklı çünkü daha hassastır
            //virgülden sonra 28-29 değer turar
            decimal number6 = 10.4m;

            //var keyword. 
            //aslında bir değişken değil, değişken tutmak için kullanılır
            //number7 'nin veri tipi direkt olarak int olarak algılanır
            var number7 = 10;
            number7 = 'A';
            



            //virgülden sonraki ilk degeri yazdırmak için 0 yazıldı.
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);//number7 ilk başta  int olduğu için A değeri atanmasına rağmen A değeri int olarak gelir ( ASCII )
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int) character);
            Console.WriteLine((int)Days.Friday); // ekranda 4 yazar friday 4. değer olduğu için (default olarak)

            Console.ReadLine();
        }

    }
    //magic string genellikle bir çok yerde tekrar eden değerler için kullanılır.
    //enumda default olarak başlangıç değeri sıfırdır.Ancak isteğe bağlı olarak bu değer değiştirilebilir
    //veya tüm değerlere farklı bir değer atanabilir aşağıdaki gibi
    enum Days
    {
        Monday=10,Tuesday =20 ,Wednesday =30 ,Thursday,Friday,Saturday,Sunday
    }
}
