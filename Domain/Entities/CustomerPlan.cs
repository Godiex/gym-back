using Domain.Entities.Base;
using Domain.Enums;

namespace Domain.Entities
{
    public class CustomerPlan : EntityBase<Guid>
    {
        public Customer Customer { get; set; }
        public Plan Plan { get; set; }
        public CustomerPlanState State { get; set; }
    }
}
