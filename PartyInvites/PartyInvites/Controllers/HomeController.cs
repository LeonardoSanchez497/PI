using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult GuestList()
    
        {
            return View(Repositoty.Responses.Where(r => r.WillAttend == true));

        }
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            string message;
            if (hour >= 7 && hour < 12) {
                message = " Good Morning";
            }
            else if (hour >= 12 && hour < 20) {
                message = " Good afternoon";
            }
            else {
                message= "Good evening";
            }

            ViewBag.Message = message;

            return View();
        }
        
        // Get: /home/Rspv
        public ViewResult Rspv()
        {
            return View();
        }
        [HttpPost]
        //Post: HOme/Rspv
        public ViewResult Rspv(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                Repositoty.AddResponse(response);
                return View("Thanks", response);
            }else
            {
                //there are validation errors
                return View();
            }
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
