using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Category
{
    [Column("CategoryId")]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }

    public ICollection<Product>? Products { get; set; }

}