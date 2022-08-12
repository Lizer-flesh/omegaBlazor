using System.ComponentModel.DataAnnotations;
namespace Landing.Server
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public List<Cart> Cart { get; set; }
    }
}
