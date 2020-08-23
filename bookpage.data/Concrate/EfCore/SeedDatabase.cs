using System.Linq;
using bookpage.entity;
using Microsoft.EntityFrameworkCore;

namespace bookpage.data.Concrate.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context=new ShopContext();
            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
            }

            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories=
        {
            new Category(){Name="Roman"},
            new Category(){Name="Kişisel Gelişim"},
            new Category(){Name="Bilim"}
        };
        private static Product[] Products=
        {
            new Product(){Name="Sadece Aptallar 8 Saat Uyur",Description="hagara hugara şagara şugara",Author="Erdal Demirkıran",Pages=180,ImageUrl="1.jpg.jpg",IsApproved=true},
            new Product(){Name="Ruhsal Zeka",Description="hagara hugara şagara şugara",Author="Muhammed Bozdağ",Pages=230,ImageUrl="2.jpg.jpg",IsApproved=true},
            new Product(){Name="İrade Terbiyesi",Description="hagara hugara şagara şugara",Author="Jules Payot",Pages=160,ImageUrl="3.jpg.jpg",IsApproved=true},
            new Product(){Name="Ben Dünyanın En Akıllı İnsanıyım",Description="hagara hugara şagara şugara",Author="Erdal Demirkıran",Pages=290,ImageUrl="4.jpg.jpg",IsApproved=true},
            new Product(){Name="Mutlu Beyin",Description="hagara hugara şagara şugara",Author="Loretta Greziona",Pages=260,ImageUrl="5.jpg",IsApproved=true},
            new Product(){Name="Nefes",Description="hagara hugara şagara şugara",Author="Michael Katz Krefeld",Pages=280,ImageUrl="6.jpg",IsApproved=true}, 
        };



    }
}