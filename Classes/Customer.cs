using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field tanımalamak
        //public string FirstName;


        //property tanımlamak
        //prop yaz tab'a iki defa tıkla
        
        public int Id { get; set; }
        //implementasyon olayının gizlenmesi denir buna.Bu da encapsulation denilen tekniktir
        //yorum satırlı kod eski bir yazım şeklidir.
        //private string _firstName;
        //public string FirstName
        //{
        //    get { return "Mrs." + _firstName; }

        //    set
        //    {
        //        //value set etmeye çalıştığımız değere karşılık gelir
        //        _firstName = value;
        //    }
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
