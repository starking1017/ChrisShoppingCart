using ShoppingCart.Data;
using ShoppingCart.Models.Cart;
using ShoppingCart.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utilities;

namespace ShoppingCart.Repositories
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public void AddList(List<OrderDetail> orderDetails)
        {
            ApplicationDbContext.OrderDetails.AddRange(orderDetails);
            Save();
        }
    }
}
