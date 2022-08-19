
namespace Landing.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}
