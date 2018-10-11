using ShoppingCart.Data;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Manager
{
    public class OrderManager : IOrderManager
    {
        private ApplicationDbContext _repoContext;
        private IOrderDetailRepository _orderDetail;
        private IOrderRepository _order;

        public OrderManager(ApplicationDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }


        public IOrderDetailRepository OrderDetailRepo
        {
            get
            {
                if (_orderDetail == null)
                {
                    _orderDetail = new OrderDetailRepository(_repoContext);
                }

                return _orderDetail;
            }
        }

        public IOrderRepository OrderRepo
        {
            get
            {
                if (_order == null)
                {
                    _order = new OrderRepository(_repoContext);
                }

                return _order;
            }
        }
    }
}
