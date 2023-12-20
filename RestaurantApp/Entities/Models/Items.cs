using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Items
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

    [ForeignKey("Categories")]
    public int CategoryId { get; set; }
    public Categories? Category { get; set; }
}