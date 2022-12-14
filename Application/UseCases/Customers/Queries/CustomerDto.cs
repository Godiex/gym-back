namespace Application.UseCases.Customers.Queries {
    public record CustomerDto {
        public Guid Id { get; set; } 
        public string Identification { get; set; } = default!;
        public float Weight { get; set; }
        public float Tall { get; set; }
        public string Names { get; set; } = default!;
        public string Surnames { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string CellPhone { get; set; } = default!;
        public PlanDto Plan { get; set; } = default!;
        public CustomerUserDto User { get; set; } = default!;
    }
    
    public record PlanDto {
        public Guid Id { get; set; } 
        public string Name { get; set; } = default!;
        public string Duration { get; set; } = default!;
    }
    
    public record CustomerUserDto {
        public Guid Id { get; set; } 
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}