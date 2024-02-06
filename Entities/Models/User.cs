using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class User
{
    public const int MinUsernameLength = 3;
    public const int MaxUsernameLength = 20;

    [Column("UserId")]
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    // Check for confirmPassword
    public string? Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; } = DateTime.Now;

    public ICollection<Review>? Reviews { get; set; }

}
