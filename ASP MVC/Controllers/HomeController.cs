using ASP_MVC.Models;
using ASP_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IRepository repository;
        ApplicationContext db;
        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            this.repository = repository;
            //db = new ApplicationContext();
        }

        public IActionResult Index()
        {
            return View(repository.GetOrders);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [ActionName("NewOrder")]
        public IActionResult AddOrder(Order order)
        {
            repository.AddOrder(order);
            return Redirect("/Home");
        }
    }
}