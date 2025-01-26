namespace test_connect_db.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; init; }

    [Required]
    [StringLength(50), MinLength(6)]
    public required string Username { get; init; }

    [Required]
    [StringLength(64), MinLength(8)]
    public required string Password { get; init; }
}