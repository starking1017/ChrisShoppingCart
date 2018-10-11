using ShoppingCart.Models.Cart;
using ShoppingCart.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    public interface IOrderDetailRepository : IRepositoryBase<OrderDetail>
    {
        void AddList(List<OrderDetail> orderDetails);
    }
}
