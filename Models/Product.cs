using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.API.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es requerido.")]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "La categoría es requerida.")]
    public string Category { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
