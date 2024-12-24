using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsolUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle -> yaptigin yazilima yeni bir ozellik ekliyorsan mevcuttaki kodlara dokunamazsin

        static void Main(string[] args)
        {
            //Data Transformation Object -> DTO -> Tasiyacagim objeleri yaziyorum




            //CategoryTest();
            //   ProductTest();

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    //IoC
        //    //Inversion of Control
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    //new ProductManager() -> Parantez icine yolladigimiz sey, kullanacagmiz teknoloji. Burada InMemory kullandik

        //    var result = productManager.GetProductDetails();

        //    if (result.Success)
        //    {
        //        foreach (var product in result.Data)
        //        {

        //            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }



    }
}
