using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            //şart bloğu. mantıksal operatörler kullanılır

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            //bu şekilde de yazabilirsin
            //Single Line if denir bu yazım tekniğine
            //şart bloğu    doğruysa      yanlışsa
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            //Switch; iflerle yapılan şart bloklarını bununla da yapabiliriz ama çok kullanılmaz

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break; //burada olayı bitir
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;

            }

            //ctrl+k ardından ctrl+d ye basınca uygulama indentation(kodun daha okunaklı olması) yapıyı tasarlar
            //ctrl+k ardından ctrl+c ye basınca seçili yerdeki kodlar yorum satırına dönüştürülür

            //&& --> Ampersand -- ve
            //|| --> Pipe -- veya
            //int sınırlarında aşağıdaki bloğa girmeyecek bir sayı yoktur.
            //Şart blokları yazarken tüm koşulları düşündüğünden emin olmalısın.

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 100-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or grater than 200");
            }

            //iç içe if'ler
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {
                    Console.WriteLine("Number is between 90-95");
                }
                else
                {
                    Console.WriteLine("Number is less than 100");
                }
            }

            Console.ReadLine();
        }
    }
}
