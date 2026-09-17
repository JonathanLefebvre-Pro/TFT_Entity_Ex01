using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ex01.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public Shop(string name)
        {
            Name = name;
        }
    }
}
