using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ex01.Entities
{
    [Table("users")]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        public string Firstname { get; set; }
        [Required]
        [Column("last_name")]
        public string Lastname { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        [Required]
        [Column("role")]
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }


        public User(string firstname, string lastname, string email) : this(firstname, lastname, email, new Role()) { }
        public User(string firstname, string lastname, string email,  Role role)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Role = role;
        }
    }
}
