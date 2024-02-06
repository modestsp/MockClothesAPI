using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Review
{
    [Column("ReviewId")]
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public decimal Rating { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; } = DateTime.Now;
}