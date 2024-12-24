using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Ciplak class kalmasin 

    //concrete icerisindeki class'lar, veritabanindaki tablolara karsilik geliyor. 
    //IEntity implement eden class bir veritabanı tablosudur.(IEntity miras aldigin zaman onun kurallarini uygularsin)

    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
