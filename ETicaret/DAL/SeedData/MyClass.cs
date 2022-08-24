using DAL.Concrete.EntityFramework.Database;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SeedData
{
    public static class MyClass
    {
        public static void Seed()
        {
            ETicaretDbContext db = new ETicaretDbContext();
            List<Category> categories = new List<Category>
            {
                 new Category{ Name="Kadın",
                    ImageUrl="/assets/img/categori/cat1.jpg"},//1 kadın
                new Category{ Name="Erkek",
                ImageUrl="/assets/img/categori/cat3.jpg"},//2 erkek
                new Category{ Name="Cocuk",
                ImageUrl="/assets/img/categori/cat2.jpg"},//3 cocuk
            };
            db.Category.AddRange(categories);
            List<Product> products = new List<Product>()
            {
                new Product{Name="Erkek Şort",Price=150,Stock=1000 },//1
                new Product{Name="Kadın Swit",Price=50,Stock=150 },//2
                new Product{Name="Çocuk Swit",Price=10,Stock=75 },//3

            };
            db.Product.AddRange(products);
            db.SaveChanges();

            List<ProductCategory> productCategories = new List<ProductCategory>
            {

                new ProductCategory{ CategoryId=2,ProductId=1},
                new ProductCategory{ CategoryId=1,ProductId=2},
                new ProductCategory{ CategoryId=3,ProductId=3},

            };
            db.ProductCategory.AddRange(productCategories);
            db.SaveChanges();

            List<ProductImage> productImages = new List<ProductImage>
            {

                new ProductImage{ ProductId=1, ImageUrl="/assets/img/categori/product1.png"},
                new ProductImage{ ProductId=2, ImageUrl="/assets/img/categori/product2.png"},
                new ProductImage{ ProductId=3, ImageUrl="/assets/img/categori/product3.png"},
                };
            db.Image.AddRange(productImages);
            db.SaveChanges();
        }
    }
}
