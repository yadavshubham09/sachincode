using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyProject.Models;
using DummyProject.Repository;

namespace DummyProject.Controllers
{
    public class InviaController : Controller
    {
        IAccountRepository accountRepository;
        public InviaController() { accountRepository = new AccountRepository(); }
        // GET: Invia
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Account account)
        {
           
                // Process the registration data and save to the database
            if(account != null)
            {
                accountRepository.Register(account);
                // Redirect to the login page or appropriate action
                return RedirectToAction("SignIn");
            }
               
            
            return View();
            // If there are validation errors, return the view with the model to display the errors
            //return View();
        }

        /*8888888888888888*/

        // GET: /Invia/SignIn
        [HttpGet]
        public ActionResult SignIn()
        {
            // Render the login form
            return View();
        }

        // POST: /Invia/SignIn
        [HttpPost]
        public ActionResult SignIn(String UserName, String Password)
        {
            int check = accountRepository.SignIn(UserName, Password);
            if (check == 1)
            {
                // Validate the user's credentials and perform sign-in
                // Example: userService.SignIn(model);
                
                // Redirect to the appropriate action or dashboard
                 return RedirectToAction("CreateEmployee","Employee");  
            }

            // If there are validation errors, return the view with the model to display the errors
            return View();
        }
    }
}