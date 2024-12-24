using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Her entity'i diger katmanlarda da tek tek kodluyoruz.


    // veri erisim katmani
    // data access layer icin once interface olusturulur.
    // bu interface'i implement eden class'lar veritabanina erisim saglar.
    

    // I-> Interface
    // Product -> Hangi tabloya erisim saglayacagini belirtir.
    // Dal -> Data Access Layer

    
    public interface IProductDal : IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();
    
    }   
}


//Code Refactoring