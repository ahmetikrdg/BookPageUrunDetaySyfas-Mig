using System.Collections.Generic;
using System.Linq;
using bookpage.data.Abstract;
using bookpage.entity;

namespace bookpage.data.Concrate.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using(var context=new ShopContext())
            {
                return context.Products.ToList();
            }
        }
    }
}