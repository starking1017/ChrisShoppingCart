using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Manager;
using ShoppingCart.Models.Cart;
using ShoppingCart.Repositories;
using Utilities;

namespace Carts.Controllers
{
    public class OrderController : Controller
    {
        private IOrderManager _orderManager;

        public OrderController(IOrderManager pOrderManager)
        {
            _orderManager = pOrderManager;
            _orderManager.ThrowIfArgumentNull(nameof(_orderManager));
        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        // Post: UpdateCart
        public ActionResult UpdateCart(int pId, int pQuantity)
        {
            Cart cart = Operation.GetCurrentCart();

            foreach (CartItem item in cart.Items.Where(pCartItem => pCartItem.Id == pId))
            {
                item.Quantity = pQuantity;
            }

            Operation.UpdateCart(cart);
            return View("Index");
        }

        [Authorize]
        [HttpPost]
        public ActionResult Index(Ship pPostback)
        {
            if (this.ModelState.IsValid)
            {
                ShipItems(pPostback);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(pPostback);
            }
        }
        private void ShipItems(Ship pPostback)
        {
            var currentcart = Operation.GetCurrentCart();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; // will give the user's userId
            var userName = User.FindFirst(ClaimTypes.Name).Value; // will give the user's name


            var order = new Order()
            {
                UserId = userId,
                UserName = userName,
                RecieverName = pPostback.ReceiverName,
                RecieverPhone = pPostback.ReceiverPhone,
                RecieverAddress = pPostback.ReceiverAddress
            };

            _orderManager.OrderRepo.Create(order);

            var orderDetails = currentcart.ToOrderDetailList(order.Id);

            _orderManager.OrderDetailRepo.AddList(orderDetails);

            Operation.RemoveCart();

            TempData["SuccessMessage"] = "Thank you! Your order has been placed! Order Number: " + order.Id;
        }

        [Authorize]
        public ActionResult MyOrder()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; // will give the user's userId
            var result = _orderManager.OrderRepo.FindByCondition(pOrder => pOrder.UserId == userId);

            if(NullUtilities.IsNotNull(result))
                return View(result);
            else
                return View();
        }

        [Authorize]
        public ActionResult MyOrderDetail(int pId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; // will give the user's userId

            // check order belong current user
            if (_orderManager.OrderRepo.FindByCondition(pA => pA.Id == pId && pA.UserId == userId).Any() == false)
                return RedirectToAction("MyOrder");

            var result = _orderManager.OrderDetailRepo.FindByCondition(pOrderDetail => pOrderDetail.OrderId == pId);

            if (NullUtilities.IsNull(result))
            {
                return RedirectToAction("MyOrder");
            }
            else
            {
                return View(result);
            }
        }
    }
}


