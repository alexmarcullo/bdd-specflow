using Lexx.Bdd.Specflow.Domain.Entities;
using Lexx.Bdd.Specflow.Domain.Repositories;
using Lexx.Bdd.Specflow.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lexx.Bdd.Specflow.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public Product Get(Guid id)
        {
            return _context
                .Products
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Product> GetLikeName(string productName)
        {
            return _context
                .Products
                .AsNoTracking()
                .Where(x => x.Name.Contains(productName));
        }

        public void Save(Product entity)
        {
            _context.Products.Add(entity);
        }
    }
}
