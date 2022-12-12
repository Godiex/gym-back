using Domain.Enums;

namespace Domain.Entities
{
    public class Customer : Person
    {
        public float Weight { get; set; }
        public float Tall { get; set; }
        public Gym Gym { get; set; }
        public Guid GymId { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }

        public Plan Plan { get; set; }
        public Guid PlanId { get; set; }

        public CustomerPlanState State { get; set; }

        public Customer()
        {
        }

        public Customer(Guid gymId, Guid planId)
        {
            GymId = gymId;
            PlanId = planId;
            State = CustomerPlanState.Active;
        }
    }
}
