using System;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public abstract class Person : EntityBase<Guid>
    {
        public string Identification { get; set; } = default!;
        public string Names { get; set; } = default!;
        public string Surnames { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string CellPhone { get; set; } = default!;
    }
}
