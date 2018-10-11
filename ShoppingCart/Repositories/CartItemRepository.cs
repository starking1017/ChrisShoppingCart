using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ShoppingCart.Data;
using ShoppingCart.Models.Cart;
using ShoppingCart.Models.Product;
using Utilities;

namespace ShoppingCart.Repositories
{
    public class CartItemRepository : RepositoryBase<CartItem>, ICartItemRepository
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartItemRepository(IHttpContextAccessor pHttpContextAccessor, ApplicationDbContext pRepositoryContext)
            : base(pRepositoryContext)
        {
            _httpContextAccessor = pHttpContextAccessor;
        }

        public IHttpContextAccessor HttpContext
        {
            get
            {
                if (_httpContextAccessor == null)
                {
                    _httpContextAccessor = new HttpContextAccessor();
                }

                return _httpContextAccessor;
            }
        }

        ApplicationDbContext ICartItemRepository.ApplicationDbContext => base.ApplicationDbContext;
    }
}