
namespace Landing.Client.Shared.Models
{
    public class Users
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public List<Cart> Orders { get; set; }
    }

    public class Cart
    {
        public int IdCart { get; set; }
        public int IdUser { get; set; }
        public string NameProduct { get; set; }
        public int QuantityProduct { get; set; }

        public List<Users> Orders { get; set; }
    }
}
