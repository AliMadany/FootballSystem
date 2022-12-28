using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M3gogo.BLL;
using M3gogo.Models;

namespace M3gogo.Controllers
{
    public class RegisterController : Controller
    {


        RegisterBLL Register1 = new RegisterBLL();

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
       


        [HttpGet]


        [ActionName("signUpAM")]
        public ActionResult signUpAM() // display view UI form to enter club details get method
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult signUpAM(AM register) // post method to get called automatically after user clicks submit button to submit form to db with club model data
        {

            Register1.signUpAM(register);



            return View(register);
        }

        
        public ActionResult signUpFan() // display view UI form to enter club details get method
        {

            return View();
        }

        [HttpPost]
        public ActionResult signUpFan(Fan register1) // post method to get called automatically after user clicks submit button to submit form to db with club model data
        {

            Register1.signUpFan(register1);



            return View(register1);
        }
    }
}