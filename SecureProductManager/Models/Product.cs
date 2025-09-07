using SecureProductManager.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SecureProductManager.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [SanitizeHtml]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, 10000.00)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 1000)]
        [Display(Name = "Quantity in Stock")]
        public int Quantity { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedDate { get; set; }

    }
}