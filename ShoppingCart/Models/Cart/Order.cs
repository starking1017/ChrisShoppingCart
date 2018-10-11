using ShoppingCart.Data;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models.Cart
{
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get;set; }
        public string RecieverName { get; set; }
        public string RecieverPhone { get; set; }
        public string RecieverAddress { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }

}
