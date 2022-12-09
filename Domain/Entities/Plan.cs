using System;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Plan : EntityBase<Guid>
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public List<Routine> Routines { get; set; }
    }
}
