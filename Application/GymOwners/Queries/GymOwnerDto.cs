namespace Application.GymOwners.Queries {
    public record GymOwnerDto {
        public Guid Id { get; set; } 
        public string Names { get; set; } = default!;
        public string Surnames { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string CellPhone { get; set; } = default!;
        public GymDto Gym { get; set; } = default!;
    }
    
    public record GymDto {
        public Guid Id { get; set; } 
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
    }
}