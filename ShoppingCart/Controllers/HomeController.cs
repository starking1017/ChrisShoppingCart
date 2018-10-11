using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Manager;
using ShoppingCart.Models;
using ShoppingCart.Models.Product;
using ShoppingCart.Repositories;
using Utilities;

namespace ShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        private IProductManager _productManager;

        public HomeController(IProductManager pProductManager)
        {
            _productManager = pProductManager;
            _productManager.ThrowIfArgumentNull(nameof(_productManager));
        }

        public IActionResult Index()
        {
            var result = _productManager.ProductRepo.FindAll().ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Index(string pSearch)
        {
            List<Product> result = new List<Product>();

            if (string.IsNullOrEmpty(pSearch))
                result = _productManager.ProductRepo.FindAll().ToList();
            else
                result = _productManager.ProductRepo.FindByCondition(p => p.Name.Contains(pSearch)
                        || p.Description.Contains(pSearch)).ToList();

            return View(result);
        }

        public ActionResult Details(int pId)
        {
            var result = _productManager.ProductRepo.FindByCondition(p => p.Id == pId).SingleOrDefault();

            if (NullUtilities.IsNull(result))
            {
                return RedirectToAction("Index");
            }
            else
            {
                var comments = _productManager.ProductCommentRepo.FindByCondition(pComment => pComment.ProductId == pId);
                ViewBag.Comment = comments;
                return View(result);
            }
        }

        [HttpPost]
        [Authorize] // must login to add comment
        public ActionResult AddReview(int id, string pContent)
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value; // will give the user's userName

            var currentDateTime = DateTime.Now;

            var comment = new ProductCommet
            {
                ProductId = id,
                Content = pContent,
                UserId = userName,
                CreateDate = currentDateTime
            };

            _productManager.ProductCommentRepo.Create(comment);

            return RedirectToAction("Details", new { pId = id });
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
