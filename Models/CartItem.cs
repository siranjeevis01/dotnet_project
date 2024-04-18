using System.ComponentModel.DataAnnotations;

namespace DOTNET_PROJECT.Models
{
    public class CartItem
    {
        public int Id { get; set; }
    
        [Required]
        public int ProductId { get; set; }
    
        [Required]
        public int Quantity { get; set; }
    
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal TotalPrice { get; set; }
    
        // Additional properties such as UserId, DateAdded, etc.
    }
}
