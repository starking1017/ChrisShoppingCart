using ShoppingCart.Data;
using ShoppingCart.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utilities;

namespace ShoppingCart.Repositories
{
    public class ProductCommentRepositoty : RepositoryBase<ProductCommet>, IProductCommentRepositoty
    {
        public ProductCommentRepositoty(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
