using System.ComponentModel.DataAnnotations;


namespace DOTNET_PROJECT.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    
        public string Description { get; set; }
    
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
    }
}