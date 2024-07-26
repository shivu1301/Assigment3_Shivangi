namespace Assignment3_Shivangi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Details { get; set; }
        public DateTime OrderDate { get; set; }

        public User? User { get; set; }
    }
}
