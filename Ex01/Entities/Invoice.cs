using System.ComponentModel.DataAnnotations;

namespace Ex01.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public Shop Shop { get; set; }
        public Client Client { get; set; }

        public Invoice() { }
        public Invoice(Shop shop, Client client)
        {
            Shop = shop;
            Client = client;
        }
    }
}
