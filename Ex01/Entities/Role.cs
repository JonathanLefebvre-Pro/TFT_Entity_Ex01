using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ex01.Entities
{
    public enum RoleType
    {
        user,
        admin
    }

    [Table("roles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        public RoleType Type { get; set; }
        [NotMapped]
        public string TypeName { get => Type.ToString(); }

        public Role() { Type = RoleType.user; }
        public Role(RoleType type)
        {
            Type = type;
        }
    }
}
