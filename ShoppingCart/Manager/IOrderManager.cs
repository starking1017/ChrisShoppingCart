﻿using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Manager
{
    public interface IOrderManager
    {
        IOrderDetailRepository OrderDetailRepo { get; }
        IOrderRepository OrderRepo { get; }

    }
}
