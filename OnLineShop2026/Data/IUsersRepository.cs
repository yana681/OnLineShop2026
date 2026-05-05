using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface IUsersRepository
    {
        List<User> GetAll();
        User? TryGetById(Guid id);
    }
}