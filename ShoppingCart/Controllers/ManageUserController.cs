using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Data;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;

namespace ShoppingCart.Controllers
{
    public class ManageUserController : Controller
    {
        private readonly IRepositoryBase<IdentityUser> _userRepo;

        public ManageUserController(IRepositoryBase<IdentityUser> pUserRepo)
        {
            _userRepo = pUserRepo;
            _userRepo.ThrowIfArgumentNull(nameof(_userRepo));

        }

        // GET: ManageUser
        public ActionResult Index()
        {
            ViewBag.ResultMessage = TempData["ResultMessage"];
            var users = _userRepo.FindAll();
            return View(users);
        }

        public ActionResult Edit(string pId)
        {
            // user id is GUID
            var result = _userRepo.FindByCondition(p=>p.Id == pId).SingleOrDefault();

            if (NullUtilities.IsNotNull(result))
            {
                return View(result);
            }
            else
            {
                TempData["ResultMessage"] = String.Format("User [{0}] not exist，please retry.", pId);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(IdentityUser pPostback)
        {
            if (this.ModelState.IsValid)
            {
                _userRepo.Update(pPostback);

                TempData["ResultMessage"] = String.Format("User [{0}] edit success.", pPostback.UserName);
                return RedirectToAction("Index");

            }
            else
            {
                return View(pPostback);
            }

        }
    }
}