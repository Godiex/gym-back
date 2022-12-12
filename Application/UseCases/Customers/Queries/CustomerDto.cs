namespace Application.UseCases.Customers.Queries {
    public record CustomerDto {
        public Guid Id { get; set; } 
        public string Names { get; set; } = default!;
        public string Surnames { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string CellPhone { get; set; } = default!;
        public PlanDto Plan { get; set; } = default!;
    }
    
    public record PlanDto {
        public Guid Id { get; set; } 
        public string Name { get; set; } = default!;
        public string Duration { get; set; } = default!;
    }
}