namespace Domain.Entities
{
    public class Customer : Person
    {
        public DateTime BirthDay { get; set; }
        public float Weight { get; set; }
        public float Tall { get; set; }
        public Gym Gym { get; set; }
        public Guid GymId { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }

        public List<CustomerPlan> CustomerPlans { get; set; }
    }
}
