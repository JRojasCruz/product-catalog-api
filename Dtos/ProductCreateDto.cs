using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.API.Dtos;

public class ProductCreateDto
{
    [Required]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    public string Category { get; set; } = null!;
}
