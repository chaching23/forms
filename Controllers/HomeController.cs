using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using view.Models;

namespace view.Controllers
{
    public class HomeController : Controller
    {





        [HttpPost("Toons")]
        public IActionResult AllToon()
        {
            List<cartoon> x =  new List<cartoon>();
            cartoon bob = new  cartoon("spongebob",2,"hello", false);
            cartoon Bugs = new  cartoon("Bugs",3,"wow", false);
            cartoon Bunny = new  cartoon("Bunny",5,"no", false);
            cartoon angel = new  cartoon("angel",7,"way", false);
            x.Add(bob);
            x.Add(Bugs);
            x.Add(Bunny);
            x.Add(angel);


            return View("Toons", x);
        }


        [HttpGet("show")]
        public IActionResult NewToon()
        {  

            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(cartoon x)
        {

            return RedirectToAction("ShowUser", x);
        }


        [HttpGet("Toons")]
        public IActionResult ShowUser(cartoon x)
        {
        
            return View("toon", x);
        }


        [HttpGet("numbers")]
        public IActionResult ShowNumbers()
        {
                // Numbers x = new  Numbers()
            {
                int[] numbers = {1,2,3,4,5,6,7};
                    


                return View("number", numbers);
            }
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            User x = new  User()
            {
                FirstName = "kian",
                LastName ="Chachi"
            };

            return View("UserDetail", x);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
