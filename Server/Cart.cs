
using System.ComponentModel.DataAnnotations;
namespace Landing.Server
{
    public class Cart
    {
        [Key]
        public int IdCart { get; set; }
        public int IdUser { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public User User { get; set; }
    }
}
