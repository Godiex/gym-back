namespace Application.UseCases.Plan.Queries {
    public record PlanByCustomerDto {
        public string Name { get; set; }
        public int Duration { get; set; }
        public List<RoutineDto> Routines { get; set; } = default!;
    }
    
    public record RoutineDto {
        public string Name { get; set; }
        public string Training { get; set; }
    }
}