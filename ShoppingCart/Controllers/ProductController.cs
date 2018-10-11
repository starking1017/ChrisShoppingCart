using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Manager;
using ShoppingCart.Models.Product;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;

namespace ShoppingCart.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private IProductManager _productManager;

        public ProductController(IProductManager pProductManager)
        {
            _productManager = pProductManager;
            _productManager.ThrowIfArgumentNull(nameof(_productManager));
        }

        // GET: Product
        public ActionResult Index()
        {
            List<Product> result = new List<Product>();

            //Receive the passed message
            ViewBag.ResultMessage = TempData["ResultMessage"];

            result = _productManager.ProductRepo.FindAll().ToList();
            return View(result);

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product pPostback)
        {
            if (this.ModelState.IsValid)
            {
                _productManager.ProductRepo.Create(pPostback);

                TempData["ResultMessage"] = String.Format("Product [{0}] create success", pPostback.Name);

                return RedirectToAction("Index");
            }
            ViewBag.ResultMessage = "Data error，Please check!";

            return View(pPostback);
        }


        // Edit page
        public ActionResult Edit(int pId)
        {
            var result = _productManager.ProductRepo.FindByCondition(p=>p.Id == pId).SingleOrDefault();
            if (NullUtilities.IsNotNull(result))
            {
                return View(result);
            }
            else
            {
                TempData["resultMessage"] = "Data error，Please try again!";
                return RedirectToAction("Index");
            }
        }

        // Edit page postback
        [HttpPost]
        public ActionResult Edit(Product pPostback)
        {
            if (this.ModelState.IsValid)
            {
                _productManager.ProductRepo.Update(pPostback);


                TempData["ResultMessage"] = String.Format("Product [{0}] edit success.", pPostback.Name);
                return RedirectToAction("Index");

            }
            else
            {
                return View(pPostback);
            }
        }

        [HttpPost]
        public ActionResult Delete(int pId)
        {
            var result = _productManager.ProductRepo.FindByCondition(p=>p.Id == pId).SingleOrDefault();
            if (NullUtilities.IsNotNull(result))
            {
                _productManager.ProductRepo.Delete(result);

                TempData["ResultMessage"] = String.Format("product [{0}] delete success", result.Name);
                return RedirectToAction("Index");
            }
            else
                TempData["resultMessage"] = "Data not exist, please check again.";
            return RedirectToAction("Index");
        }
    }
}
