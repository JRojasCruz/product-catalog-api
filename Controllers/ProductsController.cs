using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.API.Data;
using ProductCatalog.API.Models;
using ProductCatalog.API.Dtos;

namespace ProductCatalog.API.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase

{
  private readonly AppDbContext _dbContext;

  public ProductsController(AppDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  // GET: api/products
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Product>>> GetAll()
  {
    return Ok(await _dbContext.Products.ToListAsync());
  }

  // GET: api/products/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Product>> GetById(int id)
  {
    var product = await _dbContext.Products.FindAsync(id);

    if (product == null)
    {
      return NotFound();
    }

    return Ok(product);
  }

  // POST: api/products
  [HttpPost]
  public async Task<ActionResult<Product>> Create(ProductCreateDto dto)
  {
      if (!ModelState.IsValid)
          return BadRequest(ModelState);

      var product = new Product
      {
          Name = dto.Name,
          Description = dto.Description,
          Price = dto.Price,
          Category = dto.Category,
          CreatedAt = DateTime.UtcNow
      };

      _dbContext.Products.Add(product);
      await _dbContext.SaveChangesAsync();

      return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
  }
}