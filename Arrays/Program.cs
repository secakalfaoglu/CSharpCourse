using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ile metinsel veri tiplerini kullanılır. referans tiptir.
            //string array oluşturduysan elemanları da string olmalıdır.
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";
            //arraylar ile aynı tipteki değişkenleri tek bir noktadan yönetebiliyoruz.
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            //bu şekillerde de tanımlanır.
            string[] students2 = new[] { "Engin", "Derin", "Salih" };
            string[] students3 = { "Engin", "Derin", "Salih" };
            string[] students4 = new string[3] { "Engin", "Derin", "Salih" };

            //arrayi gezmek için kullanılır.
            foreach (var student in students4)
            {
                Console.WriteLine(student);
            }

            //Multy Dimensional- Çok Boyutlu Dizi
            //satır,sütun
            // string[,] regions = new string[7, 3];
            // regions[0, 0] = "İstanbul";
            string[,] regions = new string[5, 3]
            {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
                
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int  j= 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("******");
            }
            
            Console.ReadLine();
        }
    }
}
