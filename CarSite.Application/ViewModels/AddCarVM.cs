using System.ComponentModel.DataAnnotations;

namespace CarSite.Application.ViewModels
{
    public class AddCarVM
    {
        [Required(ErrorMessage = "Make is required")]
        public string? Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string? Model { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Price must be a positive number")]
        public int Price { get; set; }

        [Range(1900, int.MaxValue, ErrorMessage = "Year must be greater than 1900")]
        public int Year { get; set; }

        [Required]
        public string? Color { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "EngineSize must be a positive number")]
        public int EngineSize { get; set; }

        [Range(0.1, double.MaxValue, ErrorMessage = "FuelEfficiency must be a positive number")]
        public double FuelEfficiency { get; set; }
        public string? photos { get; set; }
    }
}
