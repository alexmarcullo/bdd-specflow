using Lexx.Bdd.Specflow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lexx.Bdd.Specflow.Repository.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
