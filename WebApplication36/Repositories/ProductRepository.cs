using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Models;

namespace WebApplication36.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly testCatProdTagContext _context;

        public ProductRepository(testCatProdTagContext context)
        {
            _context = context;
        }


        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Archive( List<int> produtsIds)
        {
            foreach (var id in produtsIds)
            {
                var product = _context.Products.Find(id);
                product.IsArchived = true;

                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public void Update(Product updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
