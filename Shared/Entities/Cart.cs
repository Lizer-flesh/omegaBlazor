namespace Landing.Shared.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity {get; set;}
        
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
