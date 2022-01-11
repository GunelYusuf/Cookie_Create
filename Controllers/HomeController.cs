using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Basket_MVC.DAL;
using Basket_MVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Basket_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PRODUCTS1> products = _context.PRODUCTS1s.ToList();


            return View(products);
        }

        public IActionResult AddBasket(int ProductId)
        {
         PRODUCTS1 pRODUCTS1s = _context.PRODUCTS1s.FirstOrDefault(p => p.Id==ProductId);
            string json = JsonSerializer.Serialize<PRODUCTS1>(pRODUCTS1s);
            
            if (pRODUCTS1s != null)
            {
                string cookieValue = Request.Cookies["basket"];

                HttpContext.Response.Cookies.Append("basket", json, new Microsoft.AspNetCore.Http.CookieOptions()
                { Path = "/" });
                return Content(cookieValue);
            }

            return Content("yatmaq");
        }
    }
}
