using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Data;
using ShoppingCart.Models.Cart;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;

namespace ShoppingCart.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartItemRepository _cartRepo;

        public CartController(ICartItemRepository pCartRepo)
        {
            _cartRepo = pCartRepo;
            _cartRepo.ThrowIfArgumentNull(nameof(_cartRepo));
        }

        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        // Get Cart View
        public ActionResult GetCart()
        {
            return PartialView("_CartPartial");
        }

        // Add product to cart
        public ActionResult AddToCart(int pId)
        {
            var currentCart = Operation.GetCurrentCart();
            currentCart.AddProduct(_cartRepo.ApplicationDbContext, pId);
            Operation.UpdateCart(currentCart);

            return PartialView("_CartPartial");
        }

        // remove product from cart
        public ActionResult RemoveFromCart(int pId)
        {
            var currentCart = Operation.GetCurrentCart();
            currentCart.RemoveProduct(pId);
            Operation.UpdateCart(currentCart);

            return PartialView("_CartPartial");
        }

        // empty the cart items
        public ActionResult ClearCart()
        {
            var currentCart = Operation.GetCurrentCart();
            currentCart.ClearCart();
            Operation.RemoveCart();

            return PartialView("_CartPartial");
        }
    }
}