
namespace Landing
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return $"Name={Name}; Surname={Surname}; Login={login}; Password={password}";
        }
    }
}
