namespace ProductSIte.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
        public int EngineSize { get; set; }
        public double FuelEfficiency { get; set; }
        public string? photos { get; set; }
    }
}
