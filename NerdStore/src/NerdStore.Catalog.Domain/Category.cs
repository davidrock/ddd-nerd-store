using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalog.Domain
{
    public class Category : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int Code { get; private set; }

        // EF Relation
        public ICollection<Product> Products { get; set; }

        protected Category() { }

        public Category(string name, int code)
        {
            Name = name;
            Code = code;

            Validate();
        }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }

        public void Validate()
        {
            AssertionConcern.AssertArgumentEmpty(Name, "Category's Name shall not be empty");
            AssertionConcern.AssertArgumentEquals(Code, 0, "Category's Code shall not be empty");
        }
    }
}
