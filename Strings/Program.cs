using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";

            //cümlenin kaç karakterden oluştuğunu verir

            var result = sentence.Length;
            Console.WriteLine(result);

            //ilgili değerin bir referansını oluşturur
            //clona dokunmadığım için hala ilk değerin çıktısı alınır.
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";
            Console.WriteLine(result2);
            
            //cümlenin ne ile bitip başladığına bakılır
            bool result3 =sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            //verinin içinde verilen değeri arar.Bulduğu indeksi yazdırır. eğer bulamazsa -1 döndürür
            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);
            
            //bulduğu ilk indeksi verir  sonra devam etmez
            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);

            //aramaya sondan başlar
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            //Cümlenin 0. karakterinden itibaren yazan ifadeyi ekle
            var result8 = sentence.Insert(0,"Hello ");
            Console.WriteLine(result8);

            //3.karakterden itibaren al
            var result9 = sentence.Substring(3);
            //3.karakterden itibaren 4 hane al al
            //var result9 = sentence.Substring(3,4);
            Console.WriteLine(result9);

            //bütün karakterleri küçüğe-büyüğe çevirmek
            var result10 = sentence.ToLower();
            Console.WriteLine(result10);
            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);

            //metindeki belirlenen ifadeleri değiştirmek için kullanılır
            var result12 = sentence.Replace(" ","-");
            Console.WriteLine(result12);

            //metinde belli bir yerden sonrasını kaldırmak için
            var result13 = sentence.Remove(2);
            //kaç tanesini kaldıracağını belirlersin
            //var result13 = sentence.Remove(2,4);
            Console.WriteLine(result13);




            Console.ReadLine();
        }

        private static void Intro()
        {
            //string metinsel verileri tutmak için kullanılan değişken tipidir
            string city = "Ankara";
            //stringler char arraylerdir
            Console.WriteLine(city[0]);//ilk eleman olan a yazar ekrana
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2; //string toplamak
            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}",city,city2)); //bellekte ekstra değilken tanımlamadan yaptık
        }
    }
}
