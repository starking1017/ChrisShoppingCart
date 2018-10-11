using Microsoft.AspNetCore.Http;
using ShoppingCart.Data;
using ShoppingCart.Models.Cart;

namespace ShoppingCart.Repositories
{
    public interface ICartItemRepository : IRepositoryBase<CartItem>
    {
        IHttpContextAccessor HttpContext { get; }
        ApplicationDbContext ApplicationDbContext { get; }

    }
}
