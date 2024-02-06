using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Product
{
    [Column("ProductId")]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Url { get; set; }
    public decimal Price { get; set; } = 0;
    public decimal Stars { get; set; } = 0;
    public string? PhotographerUrl { get; set; }
    public string? PhotographerName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; } = DateTime.Now;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<string>? Tags { get; set; }

    public static decimal GetStars(List<Review> reviews)
    {
        if (reviews == null || reviews.Count == 0)
        {
            return 0;
        }
        return reviews.Sum(r => r.Rating) / reviews.Count;
    }
}