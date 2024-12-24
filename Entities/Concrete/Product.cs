using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entities.Concrete
{
    //public: diger katmanlarda erisebilsin
    //internal: sadece Entities erisebilsin. default hali bu
    public class Product : IEntity
        //Product verı tabanı nesnesı oldugunu belırtmek ıcın ınterface ıle ımplemente edıldı
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
