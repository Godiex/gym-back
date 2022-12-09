using System;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Routine : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Training { get; set; }
    }
}
