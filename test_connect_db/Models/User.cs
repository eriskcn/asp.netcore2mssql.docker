namespace test_connect_db.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(50), MinLength(6)]
    public string Username { get; set; }

    [Required]
    [StringLength(64), MinLength(8)]
    public string Password { get; set; }
}