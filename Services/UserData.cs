namespace WebApplication1.Services
{
    public class UserData
    {
        public List<User> Users { get; set; } = new List<User>();
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
