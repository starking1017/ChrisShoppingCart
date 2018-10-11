using Microsoft.AspNetCore.Http;
using System;
using ShoppingCart.Data;

namespace ShoppingCart.Models.Cart
{
    public static class Operation
    {
        private static IHttpContextAccessor _httpContextAccessor;
        private static ApplicationDbContext _context;

        public static void Configure(IHttpContextAccessor httpContextAccessor, ApplicationDbContext appContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = appContext;
        }

        public static HttpContext Current => _httpContextAccessor.HttpContext;

        public enum CartName
        {
            Cart
        }

        public static Cart GetCurrentCart()
        {
            if (Current.Session.IsAvailable == true)
            {
                // if Session["Cart"] not exist，add new cart object
                if (Current.Session.GetObject<Cart>(CartName.Cart.ToString()) == null)
                {
                    var order = new Cart();
                    Current.Session.SetObject(CartName.Cart.ToString(), order);
                }

                // return Session["Cart"]
                return Current.Session.GetObject<Cart>(CartName.Cart.ToString());
            }
            else
            {
                throw new InvalidOperationException("System.Web.HttpContext.Current is empty. Please check!");
            }
        }

        public static void UpdateCart(Cart pCart)
        {
            Current.Session.SetObject(CartName.Cart.ToString(), pCart);
        }

        public static void RemoveCart()
        {
            Current.Session.Remove(CartName.Cart.ToString());
        }
    }
}

