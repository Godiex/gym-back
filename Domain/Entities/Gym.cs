using System;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Gym : EntityBase<Guid>
    {
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;

        public List<Customer> Customers { get; set; }
    }
}
