using System.ComponentModel.DataAnnotations;

namespace Landing
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public List<Cart> Cart { get; set; }
    }

    public class Cart
    {
        [Key]
        public int IdCart { get; set; }

        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int QuantityProduct { get; set; }

        public List<Users>  Users{ get; set; }
    }
}
