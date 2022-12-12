using System;
using Domain.Entities.Base;
using Domain.Enums;

namespace Domain.Entities
{
    public class Attendance : EntityBase<Guid>
    {
        public Customer Customer { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
