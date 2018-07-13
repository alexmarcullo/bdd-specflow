using Lexx.Bdd.Specflow.Shared.Entities;
using System;

namespace Lexx.Bdd.Specflow.Domain.Entities
{
    public class User : Entity<Guid>
    {
        public string Name { get; private set; }

        public User(string name)
            : base(Guid.NewGuid())
        {
            Name = name;
        }

        public override string ToString()
            => $"[{this.Id}]: {this.Name}";
    }
}
