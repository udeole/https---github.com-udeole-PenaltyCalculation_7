using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using PenaltyCalculation_7.Data;
using PenaltyCalculation_7.Models;


namespace PenaltyCalculation_7.Controllers;

public class HomeController : Controller
{
/*
    private readonly MyDbContext _Context;

    public HomeController(  MyDbContext Context)
    {
        _Context = Context;
    }

    public IActionResult Register()
    {
    return View();
    }

[HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
    
    if(ModelState.IsValid)
    {
        _Context.RegisterViewModels.Add(model);
       
      return RedirectToAction("Login","Home");
    }
    return View(model);

    }   


// GET: Account/Login

    public ActionResult Login()
    {
    return View();
    }

// POST: Account/Login

[HttpPost]

    public ActionResult Login(LoginViewModel model)
    {
// Check if the provided username and password match the stored data
    if (model.Username == "username" && model.Password == "password")
         {
// Login successful, redirect to the desired page
            return RedirectToAction("Register", "Home");
         }
    else
         {
// Login failed, display an error message
             ModelState.AddModelError("", "Invalid username or password.");
             return View(model);
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }*/

 
    MyDbContext db = new MyDbContext();

      


// GET: Account/Login

    public ActionResult Login()
    {
    return View();
    }

// POST: Account/Login

[HttpPost]

    public ActionResult Login(LoginViewModel model)
    {
// Check if the provided username and password match the stored data
    if (model.Username == "username" && model.Password == "password")
         {
// Login successful, redirect to the desired page
            return RedirectToAction("Register", "Home");
         }
    else
         {
// Login failed, display an error message
             ModelState.AddModelError("", "Invalid username or password.");
             return View(model);
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    

    
}
