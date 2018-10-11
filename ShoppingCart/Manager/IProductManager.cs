using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Manager
{
    public interface IProductManager
    {
        IProductCommentRepositoty ProductCommentRepo { get; }
        IProductRepositoty ProductRepo { get; }

    }
}
