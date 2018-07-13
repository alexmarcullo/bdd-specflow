using Lexx.Bdd.Specflow.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Lexx.Bdd.Specflow.Domain.Repositories
{
    public interface IProductRepository : IBaseRepository<Product, Guid>
    {
        IEnumerable<Product> GetLikeName(string productName);
    }
}
