using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionResults.Controllers
{
    public class HomeController : Controller
    {
       
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]  
        public ViewResult Login(string txtUid,string txtPwd)
        {
            return View();  
        }
        public ViewResult ForgotPassword()
        {
            return View("ForgotPwd");
        }
        public ViewResult ResetPassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml");
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");  

        }
        public ViewResult About()
        {
            return View();  //to proove about web form default engine   
        }
        public ActionResult Show(int id)
        {
            if (id == 1)
            {
                return View("Show1");
            }
            else
                return View("Show2");
        }

        //overloading Action Method
        [ActionName("Display1")]
        public ViewResult Display()
        {
            return View();
        }
        [ActionName("Display2")]
        public ViewResult Display(int? id)
        {
            return View();
        }


    }
}