using System;

namespace OOP1
{
    class Program
    {   
        //PascalCase=Kelimelerin ilk harfinin büyük yazılması
        //camelCase = ilk harfi küçük diğerleri büyük
        //case sensitive= büüyk küçük harf duyarlı

        static void Main(string[] args)
        {


            //1.YONTEM

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProdcutName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            //2.YONTEM

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, UnitPrice = 35, ProdcutName = "Kalem" };


            //3.YONTEM

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);




        }
    }
}
