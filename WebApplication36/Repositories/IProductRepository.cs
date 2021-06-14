using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Models;

namespace WebApplication36.Repositories
{
  public  interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts();
        void Add(Product product);
        void Update(Product updatedProduct);
        void Archive(List<int> produtsIds);
    }
}
