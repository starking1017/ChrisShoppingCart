using ShoppingCart.Data;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Manager
{
    public class ProductManager : IProductManager
    {
        private ApplicationDbContext _repoContext;
        private IProductCommentRepositoty _productComment;
        private IProductRepositoty _product;

        public ProductManager(ApplicationDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }


        public IProductCommentRepositoty ProductCommentRepo
        {
            get
            {
                if (_productComment == null)
                {
                    _productComment = new ProductCommentRepositoty(_repoContext);
                }

                return _productComment;
            }
        }

        public IProductRepositoty ProductRepo
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }

                return _product;
            }
        }
    }
}
