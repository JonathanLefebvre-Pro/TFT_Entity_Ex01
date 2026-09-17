using System.ComponentModel.DataAnnotations;

namespace Ex01.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
        }
    }
}
