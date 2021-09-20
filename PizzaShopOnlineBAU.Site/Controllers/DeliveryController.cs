using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShopOnlineBAU.Site.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Customer()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }
    }
}
