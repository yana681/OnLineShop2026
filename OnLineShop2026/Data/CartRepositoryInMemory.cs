using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class CartRepositoryInMemory : ICartRepository
    {
        private static List<Cart> carts = new List<Cart>()
        {
            new Cart()
        };

        public Cart? TryGetByUserId(int userId)
        {
            return carts[0];
        }
    }
}
