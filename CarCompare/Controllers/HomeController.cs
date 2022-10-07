using CarCompare.Models;
using CarCompare.Services;
using CarCompare.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarCompare.Controllers
{
    public class HomeController : Controller
    {
        //Static CompareListModel creation
        static CompareListModel CLM = new CompareListModel();

        //Index page (Home page) 
        public ActionResult Index()
        {
            return View("Index", CLM);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult Error500()
        {
            return View();
        }

        public ActionResult FilterField(String accelerationMax, String accelerationMin)
        {
            CLM.accelerationMin = float.Parse(accelerationMin);
            CLM.accelerationMax = float.Parse(accelerationMax);
            CLM.Filter();
            return View("Index", CLM);
        }

        public ActionResult HandleFilterButton(String button)
        {
            int action = Int32.Parse(button);
            switch(action)
            {
                case 1:
                    CLM.Filter();
                    break;
                case 2:
                    CLM.ResetFilter();
                    break;
            }
            return View("Index", CLM);
        }

    }
}