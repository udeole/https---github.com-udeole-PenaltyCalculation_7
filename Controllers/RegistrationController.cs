using Microsoft.AspNetCore.Mvc;
using PenaltyCalculation_7.Data;
using PenaltyCalculation_7.Models;

namespace PenaltyCalculation_7.Controllers
{
    //[Route("[controller]")]


    public class RegistrationController : Controller
    {

        /*   MyDbContext db = new MyDbContext();
           [HttpGet]
            public IActionResult Register()
           {
               return View();
           }

           [HttpPost]
           public IActionResult Register(RegisterViewModel model)
           {
               if(ModelState.IsValid)
               {

                   //using (var DbContext = new MyDbContext())
           {
               db.RegisterViewModels?.Add(model);
                                           db.SaveChanges();
           }



                   return RedirectToAction ("Success");
               }
               return View(model);
           }
           public IActionResult Success()
           {
               return View();
           }


           public IActionResult Index()
           {
               return View();
           }

           [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
           public IActionResult Error()
           {
               return View("Error!");
           }
           */

        private readonly MyDbContext _dbContext;

        public RegistrationController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                    _dbContext.RegisterViewModels?.Add(model);
                    _dbContext.SaveChanges();
                
                     return RedirectToAction("Login");
            }
                     return View(model);
        }
        


    }

}
