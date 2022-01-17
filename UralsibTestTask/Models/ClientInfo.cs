namespace UralsibTestTask.Models
{
    public class ClientInfo
    {
        public int ClientInfoId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public Client Client { get; set; }
    }
}
