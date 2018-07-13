using Lexx.Bdd.Specflow.Shared.Entities;
using System;

namespace Lexx.Bdd.Specflow.Domain.Entities
{
    public class Product : Entity<Guid>
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public Product(string name, decimal value)
            : base(Guid.NewGuid())
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
            => $"[{this.Id}]: {this.Name} = {String.Format("{0:C}",this.Value)}";
    }
}
