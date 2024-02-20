using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Dal DataAccsessLayer
    //burada polimorfizm(çok biçimlilik) yapılmıştır.
    //Polimorfizm bir nesneyi farklı amaçlarla implemente edip o implementasyonların belli bir kısmına veya tamamnına ulaşmaktır
    
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    //Genelde ayrı dosyalara yazarız bunları
    //içeriği implemente etmek için ampule tıkla


    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updaded");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted ");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted ");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerdal)
        {
            customerdal.Add();
        }
    }


}
