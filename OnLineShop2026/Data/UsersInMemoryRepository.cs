using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UsersInMemoryRepository : IUsersRepository
    {
        private static List<User> users = new List<User>
        {
            new User("yana","y@mail.com"),
            new User("vova","v@mail.com"),
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}
