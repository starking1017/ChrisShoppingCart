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
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
