using System;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class GymOwner : Person
    {
        public Gym Gym { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
