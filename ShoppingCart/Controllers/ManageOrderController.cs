using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Manager;
using ShoppingCart.Models.Cart;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Carts.Controllers
{
    public class ManageOrderController : Controller
    {
        private IOrderManager _orderManager;

        public ManageOrderController(IOrderManager pOrderManager)
        {
            _orderManager = pOrderManager;
            _orderManager.ThrowIfArgumentNull(nameof(_orderManager));
        }

        // GET: ManageOrder
        public ActionResult Index()
        {
            var result = _orderManager.OrderRepo.FindAll();

            return View(result);
        }

        // GET: OrderDetail
        public ActionResult Details(int pId)
        {
            var result = _orderManager.OrderDetailRepo.FindByCondition(pOrderDetail => pOrderDetail.OrderId == pId);

            if (NullUtilities.IsNull(result))
                return RedirectToAction("Index");
            else
                return View(result);

        }

        // Search Order By User
        public ActionResult SerachByUserName(string pSearch)
        {
            if(string.IsNullOrEmpty(pSearch))
                return RedirectToAction("Index");

            var result = _orderManager.OrderRepo.FindByCondition(pOrder => pOrder.UserName.Contains(pSearch,StringComparison.CurrentCultureIgnoreCase) 
                        || pOrder.RecieverName.Contains(pSearch,StringComparison.CurrentCultureIgnoreCase)).ToList();

            if (NullUtilities.IsNotNull(result))
                return View("Index", result);
            else
                return View("Index");
        }
    }
}