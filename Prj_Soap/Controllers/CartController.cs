﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prj_Soap.Service;
using Prj_Soap.Models.ViewModels;

namespace Prj_Soap.Controllers
{
    [CustomAuthorization(LoginPage = "/Account/Login", Roles = "User")]
    public class CartController : Controller
    {
        private CartService cartService = new CartService();
        // GET: Cart
        public ActionResult Index()
        {
            var c_id = Request.Cookies["IdCookie"].Values["customer_id"];
            var list = cartService.GetListInCart(c_id);
            return View(list);
        }

        public ActionResult CheckOut()
        {
            var c_id = Request.Cookies["IdCookie"].Values["customer_id"];
            var list = cartService.GetListInCart(c_id);
            return View(list);

        }

        [HttpPost]
        public ActionResult CheckOut(List<int> Id)
        {
            var c_id = Request.Cookies["IdCookie"].Values["customer_id"];
            var result = cartService.CheckOut(Id, c_id);
            if (!result.Success)
            {
                TempData["checkResult"] = "alert('"+ result.Message + "');";
                return RedirectToAction("Index");
            }
            else
                TempData["checkResult"] = "感謝您的訂購!";

            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            return View();
        }
    }
}