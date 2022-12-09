using System;
using Domain.Entities.Base;
using Domain.Enums;

namespace Domain.Entities
{
    public class Attendance : EntityBase<Guid>
    {
        public CustomerPlan CustomerPlan { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
