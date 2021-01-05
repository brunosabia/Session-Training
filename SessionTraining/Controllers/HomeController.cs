using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SessionTraining.Models;
using SessionTraining.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SessionTraining.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //adding data to session
        //assuming the method below will return list of Products

        //var products = Db.GetProducts();

        //Store the products to a session

        //Session["products"]=products;

        //To get what you have stored to a session

        //var products = Session["products"] as List<Product>;

        //to clear the session value

        //Session["products"]=null;

        //talvez tentar passar o user que vai setar o Session user como parametro

        //procurar como fazer a autenticação com o session.

        public IActionResult Index()
        {
            var user = new User() { UserId = 50, Username = "Teste1" };
            HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
            return View();
        }

        /*
         * 
         [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Username,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        */


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
