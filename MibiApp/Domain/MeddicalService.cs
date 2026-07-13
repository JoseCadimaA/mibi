namespace MibiApp.Domain
{
    public class MeddicalService
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string? Requirements { get; set; }

        public string? EstimatedDuration { get; set; }

        public bool IsActive { get; set; }
    }
}
