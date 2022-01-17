namespace UralsibTestTask.Models
{
    public class Buy
    {
        public int BuyId { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DateTimeBuy { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
